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
        }

        private void bAutoRun_KeyPress(object sender, KeyPressEventArgs e)
        {
            string key = e.KeyChar.ToString();
            key = GenerateKeyStrings.generateKeyString(key);
            GenericHotkeys.myDict.Add("auto run", key);
        }

        private void bTabTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            string key = e.KeyChar.ToString();
            key = GenerateKeyStrings.generateKeyString(key);
            GenericHotkeys.myDict.Add("target", key);
        }

        private void bEat_KeyPress(object sender, KeyPressEventArgs e)
        {
            string key = e.KeyChar.ToString();
            key = GenerateKeyStrings.generateKeyString(key);
            GenericHotkeys.myDict.Add("eat", key);
        }

        private void bMount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string key = e.KeyChar.ToString();
            key = GenerateKeyStrings.generateKeyString(key);
            GenericHotkeys.myDict.Add("Mount", key);
        }
    }
}
