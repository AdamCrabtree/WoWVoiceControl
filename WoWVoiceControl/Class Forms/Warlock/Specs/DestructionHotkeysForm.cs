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
    public partial class DestructionHotkeysForm : Form
    {
        WarlockHotkeys destructionHotkeys = new WarlockHotkeys();
        public DestructionHotkeysForm()
        {
            InitializeComponent();
        }

        private void bImmolate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.addHotkey("immolate", keyString);

        }

        private void bIncinerate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.addHotkey("incinerate", keyString);

        }

        private void bConflagrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.addHotkey("conflagrate", keyString);

        }

        private void bChaosBolt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.addHotkey("chaos bolt", keyString);

        }

        private void bRainOfFire_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.addHotkey("rain of fire", keyString);

        }

        private void bHavoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.addHotkey("havoc", keyString);

        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            WarlockBaseForm warlockForm = new WarlockBaseForm(destructionHotkeys);
            warlockForm.Show();
            this.Hide();
        }

        private void DestructionHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
