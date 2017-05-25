using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWVoiceControl.Class_Forms.Mage.Specs;
using WoWVoiceControl.SpecForms;

namespace WoWVoiceControl
{
    public partial class MageBaseForm : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        MageHotkeys hotkeyList;
        public MageBaseForm()
        {
            InitializeComponent();
        }
        public MageBaseForm(MageHotkeys hotkeyList)
        {
            this.hotkeyList = hotkeyList;
            InitializeComponent();
        }

        private void bArcane_Click(object sender, EventArgs e)
        {
            ArcaneHotkeysForm hotkeyForm = new ArcaneHotkeysForm();
            hotkeyForm.Show();
            this.Hide();
        }

        private void bFire_Click(object sender, EventArgs e)
        {
            FireHotkeysForm hotkeyForm = new FireHotkeysForm();
            hotkeyForm.Show();
            this.Hide();
        }

        private void bFrost_Click(object sender, EventArgs e)
        {

        }

        private void bStart_Click(object sender, EventArgs e)
        {
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            Process p = Process.GetProcessesByName("Wow-64").FirstOrDefault();
            IntPtr h = p.MainWindowHandle;
            recEngine.LoadGrammarAsync(MageGrammar.GenerateMageGrammar());
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string key;
            hotkeyList.mageHotkeyDictionary.TryGetValue(e.Result.Text, out key);
            SendKeys.Send(key);
            SendKeys.Send("+2");
        }
    }
}
