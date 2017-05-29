using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using WoWVoiceControl.ClassForms.DemonHunter.Specs;
using WoWVoiceControl.SpecForms;

namespace WoWVoiceControl
{
    public partial class DemonHunterBaseForm : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        DemonHunterHotkeys hotkeyList;
        public DemonHunterBaseForm()
        {
            InitializeComponent();

            FormClosed += DemonHunterBaseForm_FormClosed;

            hotkeyList = new DemonHunterHotkeys();


           //abilitiesDataGridView.EditingControlShowing += AbilitiesDataGridView_EditingControlShowing;

            // If the ability name column is entered, deseslect. Ability name doesn't have to be selected.
            abilitiesDataGridView.CellEnter += (sender, e) => { if (e.ColumnIndex == 0) (sender as DataGridView).ClearSelection(); };

            abilitiesDataGridView.ClearSelection();

            abilitiesDataGridView.KeyDown += AbilitiesDataGridView_KeyDown;

            abilitiesDataGridView.CellEnter += AbilitiesDataGridView_CellEnter;
            abilitiesDataGridView.CellLeave += AbilitiesDataGridView_CellLeave;
        }

        // Clear cell if keybinding was not set
        private void AbilitiesDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && (sender as DataGridView).CurrentCell.Value.Equals("Press key(s) to set keybinding..."))
                (sender as DataGridView).CurrentCell.Value = string.Empty;
        }

        // Prompt to set keybinding
        private void AbilitiesDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
                (sender as DataGridView).CurrentCell.Value = "Press key(s) to set keybinding...";
        }

        // Set the cell to the formatted key value
        private void AbilitiesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            (sender as DataGridView).CurrentCell.Value = KeyHelper.GetFormattedKeyString();
        }

        private void DemonHunterBaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bVengeance_Click(object sender, EventArgs e)
        {
            VengeanceHotkeysForm hotkeyForm = FormProvider.VengeanceHotkeysForm(hotkeyList);

            hotkeyForm.Show();
            this.Hide();
        }

        private void bHavoc_Click(object sender, EventArgs e)
        {
            HavocHotkeysForm hotkeyForm = FormProvider.HavocHotkeysForm(hotkeyList);
            hotkeyForm.Show();
            this.Hide();
        }

        private void bStart_Click(object sender, EventArgs e)
        {

            // When start is clicked, iterate through table rows to set the keybindings to the key string that will be sent to SendKeys
            foreach (DataGridViewRow row in abilitiesDataGridView.Rows)
            {
                if (row.Cells[1].Value == null)
                    continue;

                string ability = row.Cells[0].Value.ToString(), keybind = KeyHelper.GetKeyString(row.Cells[1].Value.ToString());

                hotkeyList.AddHotKey(ability, keybind);
            }

            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            Process p = Process.GetProcessesByName("Wow-64").FirstOrDefault();
            IntPtr h = p.MainWindowHandle;
            recEngine.LoadGrammarAsync(DemonHunterGrammar.GenerateDemonHunterGrammar());
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string key;
            try
            {
                hotkeyList.ClassAbilityDictionary.TryGetValue(e.Result.Text, out key);
                SendKeys.Send(key);
            }
            catch
            {
                SpeechSynthesizer mySynth = new SpeechSynthesizer();
                mySynth.SpeakAsync("This ability is not bound!");
            }
        }

        private void DHBaseForm_Load(object sender, EventArgs e)
        {
            // On load, iterate through known abilities and add them to datagridview. Perhaps in future allow for saving to and reading from file
            foreach (string ability in DemonHunterGrammar.BaseDemonHunterAbilities)
            {
                int index = abilitiesDataGridView.Rows.Add();

                abilitiesDataGridView.Rows[index].Cells["abilityNameColumn"].Value = ability;
            }
        }
    }
}
