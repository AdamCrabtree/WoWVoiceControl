using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWVoiceControl
{
    public partial class GenericHotkeysForm : Form
    {
        public GenericHotkeysForm()
        {
            InitializeComponent();
            GenericHotkeys.GenericKeys.Add("target", "{TAB}");
        }

        private void bAutoRun_KeyPress(object sender, KeyPressEventArgs e)
        {
            string key = e.KeyChar.ToString();
            key = GenerateKeyStrings.generateKeyString(key);
            GenericHotkeys.GenericKeys.Add("auto run", key);
        }
        private void bEat_KeyPress(object sender, KeyPressEventArgs e)
        {
            string key = e.KeyChar.ToString();
            key = GenerateKeyStrings.generateKeyString(key);
            GenericHotkeys.GenericKeys.Add("eat", key);
        }

        private void bMount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string key = e.KeyChar.ToString();
            key = GenerateKeyStrings.generateKeyString(key);
            GenericHotkeys.GenericKeys.Add("Mount", key);
        }
    }
}
