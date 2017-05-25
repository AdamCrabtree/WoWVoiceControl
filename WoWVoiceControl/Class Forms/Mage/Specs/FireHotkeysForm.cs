using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWVoiceControl.SpecForms;

namespace WoWVoiceControl.Class_Forms.Mage.Specs
{
    public partial class FireHotkeysForm : Form
    {
        MageHotkeys fireHotkeys = new MageHotkeys();
        public FireHotkeysForm()
        {
            InitializeComponent();
        }

        private void bFireball_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("fireball", keyString);
        }

        private void bBlazingBarrier_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("blazing barrier", keyString);
        }

        private void bPyroblast_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("pyroblast", keyString);

        }

        private void bCombustion_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("combustion", keyString);
        }

        private void bInvisibility_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("invisibility", keyString);
        }

        private void bScorch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("scorch", keyString);

        }

        private void bFireBlast_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("fire blast", keyString);

        }

        private void bFlameStrike_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("flame strike", keyString);
        }

        private void bDragonsBreath_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("dragons breath", keyString);

        }

        private void bShimmer_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("shimmer", keyString);
        }

        private void bBlastWave_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("blast wave", keyString);
        }

        private void bMirrorImage_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("mirror image", keyString);
        }

        private void bRuneOfPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("rune of power", keyString);

        }

        private void bRingOfFrost_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("ring of frost", keyString);

        }

        private void bLivingBomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("living bomb", keyString);
        }

        private void bCinderstorm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("cinderstorm", keyString);
        }

        private void bMeteor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            fireHotkeys.addHotkey("meteor", keyString);
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            MageBaseForm myForm = new MageBaseForm(fireHotkeys);
            myForm.Show();
            this.Hide();
        }
    }
}
