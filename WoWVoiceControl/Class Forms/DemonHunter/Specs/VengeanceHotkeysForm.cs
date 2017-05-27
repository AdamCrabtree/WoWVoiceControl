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
    public partial class VengeanceHotkeysForm : Form
    {
        DHHotkeys VengeanceHotkeys = new DHHotkeys();
        public VengeanceHotkeysForm()
        {
            InitializeComponent();
        }
        private void bSoul_Barrier_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Soul Barrier", keyString);
        }

        private void bFel_Devastation_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Fel Devastation", keyString);
        }

        private void bSpirit_Bomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Spirit Bomb", keyString);
        }

        private void bFel_Eruption_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Fel Eruption", keyString);
        }

        private void bSigil_of_Chains_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Sigil of Chains", keyString);

        }

        private void bSigil_of_Misery_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Sigil of Misery", keyString);

        }

        private void bFracture_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Fracture", keyString);
        }

        private void bFelblade_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Felblade", keyString);

        }

        private void bSigil_of_Silence_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Sigil of Silence", keyString);
        }

        private void bDemon_Spikes_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Demon Spikes", keyString);
        }

        private void bFiery_Brand_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Fiery Brand", keyString);

        }

        private void bShear_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Shear", keyString);
        }

        private void bSigil_of_Flame_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Sigil of Flame", keyString);
        }

        private void bSoul_Cleave_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Soul Cleave", keyString);

        }

        private void bImmolation_Aura_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            VengeanceHotkeys.addHotkey("Immolation Aura", keyString);

        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            DHBaseForm myForm = new DHBaseForm(VengeanceHotkeys);
            this.Hide();
            myForm.Show();
        }
    }
}
