using System;
using System.Windows.Forms;

namespace WoWVoiceControl.ClassForms.Warlock.Specs
{
    public partial class AfflictionHotkeysForm : Form
    {
        WarlockHotkeys afflictionHotkeys;
        public AfflictionHotkeysForm(WarlockHotkeys keys)
        {
            InitializeComponent();

            afflictionHotkeys = keys;

            // If the ability name column is entered, deseslect. Ability name doesn't have to be selected.
            abilitiesDataGridView.CellEnter += (sender, e) => { if (e.ColumnIndex == 0) (sender as DataGridView).ClearSelection(); };

            abilitiesDataGridView.ClearSelection();

            abilitiesDataGridView.KeyDown += AbilitiesDataGridView_KeyDown;
            abilitiesDataGridView.CellEnter += AbilitiesDataGridView_CellEnter;
            abilitiesDataGridView.CellLeave += AbilitiesDataGridView_CellLeave;
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

                afflictionHotkeys.AddHotKey(currentAbilityName, key);
            }

            Close();
        }

        private void bCorruption_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("corruption", keyString);
        }

        private void bAgony_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("agony", keyString);

        }

        private void bUnstableAffliction_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("unstable affliction", keyString);

        }

        private void bDrainSoul_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("drain soul", keyString);

        }

        private void bSeedOfCorruption_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("seed of corruption", keyString);

        }

        private void bHaunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("haunt", keyString);

        }

        private void bHowlOfTerror_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("howl of terror", keyString);

        }

        private void bSiphonLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("siphon life", keyString);

        }

        private void bGrimoreOfSacrifice_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("grimore of sacrifice", keyString);

        }

        private void bSoulEffigy_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("soul effigy", keyString);

        }

        private void bPhantomSingularity_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.AddHotKey("phantom singularity", keyString);

        }

        private void AfflictionHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.WarlockBaseForm.Show();
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

        private void AfflictionHotkeysForm_Load(object sender, EventArgs e)
        {
            foreach (string ability in WarlockGrammar.AfflictionWarlockAbilities)
            {
                int index = abilitiesDataGridView.Rows.Add();

                abilitiesDataGridView.Rows[index].Cells["abilityNameColumn"].Value = ability;
            }
        }
    }
}
