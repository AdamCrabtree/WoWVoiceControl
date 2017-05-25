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
            InitializeComponent();
            /*
            Process p = Process.GetProcessesByName("Wow-64").FirstOrDefault();
            IntPtr h = p.MainWindowHandle;
            Choices commands = new Choices();
            commands.Add(new string[] { "fire blast", "fireball", "pyroblast", "frost nova", "target", "map", "talents", "mount", "quest log", "dragons breath", "eat", "food", "walk", "turn in"});
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            TimeSpan interval = new TimeSpan(0,0,0,0,1);
            recEngine.EndSilenceTimeout = interval;
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            */
        }


        /*    private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
            {
                switch (e.Result.Text)
                {
                    case "target":
                        InputSimulator inputSimulator = new InputSimulator();
                        inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_W);
                        break;
                    case "fireball":
                        SendKeys.Send("1");
                        break;
                    case "fire blast":
                        SendKeys.Send("3");
                        break;
                    case "pyroblast":
                        SendKeys.Send("2");
                        break;
                    case "frost nova":
                        SendKeys.Send("5");
                        break;
                    case "mount":
                        SendKeys.Send("+1");
                        break;
                    case "combustion":
                        SendKeys.Send("+5");
                        break;
                    case "quest log":
                        SendKeys.Send("l");
                        break;
                    case "dragons breath":
                        SendKeys.Send("4");
                        break;
                    case "food":
                        SendKeys.Send("+2");
                        break;
                    case "eat":
                        SendKeys.Send("+3");
                        break;
                    case "walk":
                        SendKeys.Send("{CAPSLOCK}");
                        break;
                    case "turn in":
                        DoMouseClick();
                        break;
                }
            }

            public void DoMouseClick()
            {
                //Call the imported function with the cursor's current position
                uint X = (uint)Cursor.Position.X;
                uint Y = (uint)Cursor.Position.Y;
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 73, 532);
            }
            */
        private void bMageLaunch_Click(object sender, EventArgs e)
        {
            MageBaseForm mageForm = new MageBaseForm();
            mageForm.Show();
            this.Hide();
        }

        private void bGenericHotkeys_Click(object sender, EventArgs e)
        {

        }
    }
}
