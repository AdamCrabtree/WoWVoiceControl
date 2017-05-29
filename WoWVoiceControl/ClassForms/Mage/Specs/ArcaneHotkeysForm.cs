using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWVoiceControl.SpecForms
{
    public partial class ArcaneHotkeysForm : Form
    {
        MageHotkeys arcaneHotkeys = new MageHotkeys();
        public ArcaneHotkeysForm()
        {
            InitializeComponent();
        }
        private void bPresenceOfMind_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("presense of mind", keyString);
        }

        private void bArcaneExploision_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("arcane exploision", keyString);
        }

        private void bArcaneBlast_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("arcane blast", keyString);
        }

        private void bSlow_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("slow", keyString);
        }

        private void bArcaneBarrage_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("arcane barrage", keyString);

        }

        private void bArcaneMissles_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("arcane missiles", keyString);

        }

        private void bEvocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("evocation", keyString);
        }

        private void bArcanePower_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("arcane power", keyString);

        }

        private void bDisplacement_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("displacement", keyString);
        }

        private void bGreaterInvisibility_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("greater invisibility", keyString);
        }

        private void bPrismaticBarrier_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("prismatic barrier", keyString);

        }

        private void bMasterySavant_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("mastery savant", keyString);
        }

        private void bArcaneFamiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("arcane familiar", keyString);
        }

        private void bMirrorImage_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("mirror image", keyString);

        }

        private void bRunesOfPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("runes of power", keyString);

        }

        private void bSupernova_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("supernova", keyString);

        }

        private void bChargedUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("charged up", keyString);

        }

        private void bNetherTempest_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("nether tempest", keyString);

        }

        private void bArcaneOrb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            arcaneHotkeys.addHotkey("arcane orb", keyString);
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            MageBaseForm myForm = new MageBaseForm(arcaneHotkeys);
            this.Hide();
            myForm.Show();
        }

        private void ArcaneHotkeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
