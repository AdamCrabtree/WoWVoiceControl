using System;
using System.Windows.Forms;
using WoWVoiceControl.SpecForms;

namespace WoWVoiceControl.ClassForms.DemonHunter.Specs
{
    public partial class HavocHotkeysForm : Form
    {
        DemonHunterHotkeys HavocHotkeys;
        public HavocHotkeysForm(DemonHunterHotkeys keys)
        {
            InitializeComponent();

            FormClosed += HavocHotkeysForm_FormClosed;

            HavocHotkeys = keys;

            // If the ability name column is entered, deseslect. Ability name doesn't have to be selected.
            abilitiesDataGridView.CellEnter += (sender, e) => { if (e.ColumnIndex == 0) (sender as DataGridView).ClearSelection(); };

            abilitiesDataGridView.ClearSelection();

            abilitiesDataGridView.KeyDown += AbilitiesDataGridView_KeyDown;
            abilitiesDataGridView.CellEnter += AbilitiesDataGridView_CellEnter;
            abilitiesDataGridView.CellLeave += AbilitiesDataGridView_CellLeave;
        }

        private void AbilitiesDataGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

        private void HavocHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.DemonHunterBaseForm.Show();
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

        private void bAccept_Click(object sender, EventArgs e)
        {
            string currentAbilityName = string.Empty;

            try
            {
                foreach (DataGridViewRow row in abilitiesDataGridView.Rows)
                {
                    // Get the name of current ability
                    currentAbilityName = row.Cells["abilityNameColumn"].Value.ToString();

                    if (row.Cells["keybindColumn"].Value == null)
                        continue;

                    // Get the key
                    string key = row.Cells["keybindColumn"].Value.ToString();


                    key = KeyHelper.GetKeyString(key);

                    HavocHotkeys.AddHotKey(currentAbilityName, key);
                }
            }
            catch (NullReferenceException)
            {
                if (MessageBox.Show($"Please complete keybind entry before clicking accept. {currentAbilityName}", "", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                    Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DemonHunterBaseForm myForm = FormProvider.DemonHunterBaseForm;
            myForm.Show();
            this.Close();
        }

        private void HavocHotkeysForm_Load(object sender, EventArgs e)
        {
            foreach (string ability in DemonHunterGrammar.HavocDemonHunterAbilities)
            {
                int index = abilitiesDataGridView.Rows.Add();

                abilitiesDataGridView.Rows[index].Cells["abilityNameColumn"].Value = ability;
            }
        }


        private void HavocHotkeysForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
