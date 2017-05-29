using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWVoiceControl.ClassForms.Warlock.Specs
{
    public partial class DestructionHotkeysForm : Form
    {
        WarlockHotkeys destructionHotkeys;
        public DestructionHotkeysForm(WarlockHotkeys keys)
        {
            InitializeComponent();

            destructionHotkeys = keys;
        }

        private void bImmolate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.AddHotKey("immolate", keyString);

        }

        private void bIncinerate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.AddHotKey("incinerate", keyString);

        }

        private void bConflagrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.AddHotKey("conflagrate", keyString);

        }

        private void bChaosBolt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.AddHotKey("chaos bolt", keyString);

        }

        private void bRainOfFire_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.AddHotKey("rain of fire", keyString);

        }

        private void bHavoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            destructionHotkeys.AddHotKey("havoc", keyString);

        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DestructionHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.WarlockBaseForm.Show();
        }
    }
}
