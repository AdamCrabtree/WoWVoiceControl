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
    public partial class Frost : Form
    {
        MageHotkeys frostHotkeys = new MageHotkeys();
        public Frost()
        {
            InitializeComponent();
        }

        private void Frost_Load(object sender, EventArgs e)
        {

        }

        private void bFrostBolt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("frostbolt", keyString);
        }

        private void bIceLance_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("ice lance", keyString);
        }

        private void bSummonWaterElemental_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("summon water elemental", keyString);

        }

        private void bFlurry_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("flurry", keyString);

        }

        private void bIceFloes_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("ice floes", keyString);

        }

        private void bConeOfCold_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("cone of cold", keyString);

        }

        private void bIcyVeins_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("icy veins", keyString);

        }

        private void bBlizzard_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("blizzard", keyString);

        }

        private void bIceBarrier_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("ice barrier", keyString);

        }

        private void bInvisibility_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("invisibility", keyString);

        }

        private void bRayOfFrost_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("ray of frost", keyString);

        }

        private void bIceNova_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("ice nova", keyString);


        }

        private void bFrozenTouch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("frozen touch", keyString);


        }

        private void bFrostBomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("frost bomb", keyString);

        }

        private void bGlacialSpike_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("glacial spike", keyString);

        }

        private void bCometStorm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            frostHotkeys.addHotkey("comet storm", keyString);

        }
    }
}
