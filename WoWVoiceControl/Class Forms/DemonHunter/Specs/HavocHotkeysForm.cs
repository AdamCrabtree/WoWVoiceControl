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

namespace WoWVoiceControl.Class_Forms.DemonHunter.Specs
{
    public partial class HavocHotkeysForm : Form
    {
        DHHotkeys HavocHotkeys = new DHHotkeys();
        public HavocHotkeysForm()
        {
            InitializeComponent();
        }

        private void bFel_Barrage_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Fel Barrage", keyString);
        }

        private void bFel_Eruption_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Fel Eruption", keyString);
        }

        private void bNemesis_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Nemesis", keyString);

        }

        private void bCNetherwalk_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Netherwalk", keyString);
        }

        private void bChaos_Strike_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Chaos Strike", keyString);
        }

        private void bFelblade_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Felblade", keyString);

        }

        private void bBlade_Dance_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Blade Dance", keyString);

        }

        private void bBlur_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Blur", keyString);
        }

        private void bChaos_Nova_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Chaos Nova", keyString);

        }

        private void bEye_Beam_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Eye Beam", keyString);
        }

        private void bFel_Rush_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Fel Rush", keyString);
        }

        private void bSoul_Carver_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Soul Carver", keyString);
        }

        private void bVengeful_Retreat_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Vengeful Retreatr", keyString);

        }

        private void bFury_of_the_Illidari_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Fury of the Illidari", keyString);

        }

        private void bDemons_Bite_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            HavocHotkeys.addHotkey("Demon\'s Bite", keyString);
        }

      
        private void bAccept_Click(object sender, EventArgs e)
        {
            DHBaseForm myForm = new DHBaseForm(HavocHotkeys);
            myForm.Show();
            this.Hide();
        }
    }
}
