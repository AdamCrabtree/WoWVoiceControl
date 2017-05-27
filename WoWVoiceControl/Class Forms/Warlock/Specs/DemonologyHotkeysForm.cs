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
    public partial class DemonologyHotkeysForm : Form
    {
        WarlockHotkeys demonologyHotkeys = new WarlockHotkeys();
        public DemonologyHotkeysForm()
        {
            InitializeComponent();
        }

        private void bShadowBolt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.addHotkey("shadowbolt", keyString);

        }

        private void bHandOfGulDan_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.addHotkey("hand of gul dan", keyString);

        }

        private void bDemonicEmpowerment_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.addHotkey("demonic empowerment", keyString);

        }

        private void bCallDreadstalkers_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.addHotkey("call dreadstalkers", keyString);

        }

        private void bDoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.addHotkey("doom", keyString);

        }

        private void bDemonwrath_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.addHotkey("demonwrath", keyString);

        }

        private void bSummonFelguard_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.addHotkey("summon felguard", keyString);

        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            WarlockBaseForm warlockForm = new WarlockBaseForm(demonologyHotkeys);
            this.Hide();
            warlockForm.Show();
        }

        private void DemonologyHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
