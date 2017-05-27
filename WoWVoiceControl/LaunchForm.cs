using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Diagnostics;
using System.Speech.Recognition;
using System.Runtime.InteropServices;
using WindowsInput;

namespace WoWVoiceControl
{
    public partial class LaunchForm : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public LaunchForm()
        {
            GenericHotkeys.myDict.Add("target", "{TAB}");
            InitializeComponent();
        }
        
        private void bMageLaunch_Click(object sender, EventArgs e)
        {
            MageBaseForm mageForm = new MageBaseForm();
            mageForm.Show();
            this.Hide();
        }

        private void bGenericHotkeys_Click(object sender, EventArgs e)
        {
            GenericHotkeysForm myHotkeys = new GenericHotkeysForm();
            myHotkeys.ShowDialog();
        }

        private void LaunchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bWarlockLaunch_Click(object sender, EventArgs e)
        {
            WarlockBaseForm warlockForm = new WarlockBaseForm();
            warlockForm.Show();
            this.Hide();
        }
    }
}
