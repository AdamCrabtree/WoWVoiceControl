using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWVoiceControl.Class_Forms.Warlock.Specs
{
    public partial class AfflictionHotkeysForm : Form
    {
        WarlockHotkeys afflictionHotkeys = new WarlockHotkeys();
        public AfflictionHotkeysForm()
        {
            InitializeComponent();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            WarlockBaseForm warlockForm = new WarlockBaseForm(afflictionHotkeys);
            warlockForm.Show();
            this.Hide();
        }

        private void bCorruption_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("corruption", keyString);
        }

        private void bAgony_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("agony", keyString);

        }

        private void bUnstableAffliction_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("unstable affliction", keyString);

        }

        private void bDrainSoul_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("drain soul", keyString);

        }

        private void bSeedOfCorruption_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("seed of corruption", keyString);

        }

        private void bHaunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("haunt", keyString);

        }

        private void bHowlOfTerror_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("howl of terror", keyString);

        }

        private void bSiphonLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("siphon life", keyString);

        }

        private void bGrimoreOfSacrifice_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("grimore of sacrifice", keyString);

        }

        private void bSoulEffigy_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("soul effigy", keyString);

        }

        private void bPhantomSingularity_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            afflictionHotkeys.addHotkey("phantom singularity", keyString);

        }

        private void AfflictionHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
