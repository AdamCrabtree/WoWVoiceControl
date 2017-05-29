using System;
using System.Windows.Forms;

namespace WoWVoiceControl.SpecForms
{
    public partial class VengeanceHotkeysForm : Form
    {
        DemonHunterHotkeys VengeanceHotkeys;
        public VengeanceHotkeysForm(DemonHunterHotkeys hotkeys)
        {
            InitializeComponent();

            VengeanceHotkeys = hotkeys;

            FormClosed += VengeanceHotkeysForm_FormClosed;

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

        private void VengeanceHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
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
            foreach (DataGridViewRow row in abilitiesDataGridView.Rows)
            {
                // Get the name of current ability
                string currentAbilityName = row.Cells["abilityNameColumn"].Value.ToString();

                if (row.Cells["keybindColumn"].Value == null || row.Cells["keybindColumn"].Value.Equals("Press key(s) to set keybinding..."))
                    continue;

                // Get the key
                string key = row.Cells["keybindColumn"].Value.ToString();

                key = KeyHelper.GetKeyString(key);

                VengeanceHotkeys.AddHotKey(currentAbilityName, key);
            }

            Close();
        }

        private void VengeanceHotkeysForm_Load(object sender, EventArgs e)
        {
            foreach (string ability in DemonHunterGrammar.VengeanceDemonHunterAbilities)
            {
                int index = abilitiesDataGridView.Rows.Add();

                abilitiesDataGridView.Rows[index].Cells["abilityNameColumn"].Value = ability;
            }
        }
    }
}
