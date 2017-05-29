using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using WoWVoiceControl.ClassForms.Warlock;

namespace WoWVoiceControl
{
    public partial class WarlockBaseForm : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        WarlockHotkeys hotkeyList;
        public WarlockBaseForm()
        {
            InitializeComponent();

            hotkeyList = new WarlockHotkeys();

            FormClosed += WarlockBaseForm_FormClosed;

            // If the ability name column is entered, deseslect. Ability name doesn't have to be selected.
            abilitiesDataGridView.CellEnter += (sender, e) => { if (e.ColumnIndex == 0) (sender as DataGridView).ClearSelection(); };

            abilitiesDataGridView.ClearSelection();

            abilitiesDataGridView.KeyDown += AbilitiesDataGridView_KeyDown;
            abilitiesDataGridView.CellEnter += AbilitiesDataGridView_CellEnter;
            abilitiesDataGridView.CellLeave += AbilitiesDataGridView_CellLeave;
        }

        private void AbilitiesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if ((sender as DataGridView).CurrentCellAddress.X == 1)
            {
                string formattedString = KeyHelper.GetFormattedKeyString();

                if (formattedString.Contains("NumPad"))
                {
                    MessageBox.Show("Numpad keybinds not allowed (yet)");
                    return;
                }

                (sender as DataGridView).CurrentCell.Value = formattedString;
            }
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

        private void WarlockBaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bAffliction_Click(object sender, EventArgs e)
        {
            FormProvider.AfflictionHotkeysForm(hotkeyList).Show();

            this.Hide();
        }

        private void bDemonology_Click(object sender, EventArgs e)
        {
            FormProvider.DemonologyHotkeysForm(hotkeyList).Show();

            this.Hide();
        }

        private void bDestruction_Click(object sender, EventArgs e)
        {
            FormProvider.DestructionHotkeysForm(hotkeyList).Show();

            this.Hide();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in abilitiesDataGridView.Rows)
            {
                // Get the name of current ability
                string currentAbilityName = row.Cells["abilityNameColumn"].Value.ToString();

                if (row.Cells["keybindColumn"].Value == null || row.Cells["keybindColumn"].Value.Equals("Press key(s) to set keybinding..."))
                    continue;

                // Get the key
                string key = row.Cells["keybindColumn"].Value.ToString();

                key = KeyHelper.GetKeyString(key);

                hotkeyList.AddHotKey(currentAbilityName, key);
            }

            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            Process p = Process.GetProcessesByName("Wow-64").FirstOrDefault();
            // IntPtr h = p.MainWindowHandle;
            recEngine.LoadGrammarAsync(WarlockGrammar.GenerateWarlockGrammar());
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
                SpeechSynthesizer errorSynth = new SpeechSynthesizer();
                errorSynth.SpeakAsync("Command not bound");
            }
        }

        private void WarlockBaseForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void WarlockBaseForm_Load(object sender, EventArgs e)
        {
            foreach (string ability in WarlockGrammar.BaseWarlockAbilities)
            {
                int index = abilitiesDataGridView.Rows.Add();

                abilitiesDataGridView.Rows[index].Cells["abilityNameColumn"].Value = ability;
            }
        }
    }
}
