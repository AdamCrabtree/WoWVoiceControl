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
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
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
    }
}
