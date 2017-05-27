using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWVoiceControl.Class_Forms.DemonHunter.Specs;
using WoWVoiceControl.SpecForms;

namespace WoWVoiceControl
{
    public partial class DHBaseForm : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        DHHotkeys hotkeyList;
        public DHBaseForm()
        {
            InitializeComponent();
        }
        public DHBaseForm(DHHotkeys hotkeyList)
        {
            this.hotkeyList = hotkeyList;
            InitializeComponent();
        }

        private void bVengeance_Click(object sender, EventArgs e)
        {
            VengeanceHotkeysForm hotkeyForm = new VengeanceHotkeysForm();
            hotkeyForm.Show();
            this.Hide();
        }

        private void bHavoc_Click(object sender, EventArgs e)
        {
            HavocHotkeysForm hotkeyForm = new HavocHotkeysForm();
            hotkeyForm.Show();
            this.Hide();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            Process p = Process.GetProcessesByName("Wow-64").FirstOrDefault();
            IntPtr h = p.MainWindowHandle;
            recEngine.LoadGrammarAsync(DHGrammar.GenerateDHGrammar());
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string key;
            try
            {
                hotkeyList.DHHotkeyDictionary.TryGetValue(e.Result.Text, out key);
                SendKeys.Send(key);
            }
            catch
            {
                SpeechSynthesizer mySynth = new SpeechSynthesizer();
                mySynth.SpeakAsync("This ability is not bound!");
            }
        }
    }
}
