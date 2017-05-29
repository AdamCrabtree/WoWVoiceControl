using System;
using System.Windows.Forms;

namespace WoWVoiceControl.ClassForms.Warlock.Specs
{
    public partial class DemonologyHotkeysForm : Form
    {

        private WarlockHotkeys demonologyHotkeys;

        public DemonologyHotkeysForm(WarlockHotkeys keys)
        {
            InitializeComponent();

            demonologyHotkeys = keys;
        }

        private void bShadowBolt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.AddHotKey("shadowbolt", keyString);

        }

        private void bHandOfGulDan_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.AddHotKey("hand of gul dan", keyString);

        }

        private void bDemonicEmpowerment_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.AddHotKey("demonic empowerment", keyString);

        }

        private void bCallDreadstalkers_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.AddHotKey("call dreadstalkers", keyString);

        }

        private void bDoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.AddHotKey("doom", keyString);

        }

        private void bDemonwrath_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.AddHotKey("demonwrath", keyString);

        }

        private void bSummonFelguard_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            demonologyHotkeys.AddHotKey("summon felguard", keyString);

        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void DemonologyHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.WarlockBaseForm.Show();
        }
    }
}
