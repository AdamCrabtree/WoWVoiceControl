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
using WoWVoiceControl.Class_Forms.Warlock;
using WoWVoiceControl.Class_Forms.Warlock.Specs;

namespace WoWVoiceControl
{
    public partial class WarlockBaseForm : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        WarlockHotkeys hotkeyList;
        public WarlockBaseForm()
        {
            InitializeComponent();
        }
        public WarlockBaseForm(WarlockHotkeys hotkeyList)
        {
            this.hotkeyList = hotkeyList;
            InitializeComponent();
        }

        private void bAffliction_Click(object sender, EventArgs e)
        {
            AfflictionHotkeysForm afflictionForm = new AfflictionHotkeysForm();
            afflictionForm.Show();
            this.Hide();
        }

        private void bDemonology_Click(object sender, EventArgs e)
        {
            DemonologyHotkeysForm demonologyForm = new DemonologyHotkeysForm();
            demonologyForm.Show();
            this.Hide();
        }

        private void bDestruction_Click(object sender, EventArgs e)
        {
            DestructionHotkeysForm destructionForm = new DestructionHotkeysForm();
            destructionForm.Hide();
            this.Hide();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            Process p = Process.GetProcessesByName("Wow-64").FirstOrDefault();
           // IntPtr h = p.MainWindowHandle;
            recEngine.LoadGrammarAsync(WarlockGrammar.GenerateWarlockGrammar());
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string key;
            try
            {
                hotkeyList.WarlockHotkeyDictionary.TryGetValue(e.Result.Text, out key);
                SendKeys.Send(key);
            }
            catch
            {
                SpeechSynthesizer errorSynth = new SpeechSynthesizer();
                errorSynth.SpeakAsync("Command not bound");
            }
        }

        private void bDrainLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("drain life", keyString);
        }

        private void bSummonImp_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("summon imp", keyString);

        }

        private void bSoulLeach_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("soul leach", keyString);


        }

        private void bCreateHealthstone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("create healthstone", keyString);

        }

        private void bSummonVoidwalker_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("summon voidwalker", keyString);


        }

        private void bFear_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("fear", keyString);

        }

        private void bSoulstone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("soulstone", keyString);

        }

        private void bHealthFunnel_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("health funnel", keyString);


        }

        private void bEyeOfKilrogg_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("eye of kilrogg", keyString);

        }

        private void bUnendingBreath_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("unending breath", keyString);

        }

        private void bSummonSuccubus_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("summon succubus", keyString);

        }

        private void bCommandDemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("command demon", keyString);

        }

        private void bBanish_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("banish", keyString);

        }

        private void bLifeTap_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("life tap", keyString);

        }

        private void bSummonFelhunter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("summon felhunter", keyString);

        }

        private void bSummonInfernal_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("summon infernal", keyString);


        }

        private void bEnslaveDemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("enslave demon", keyString);


        }

        private void bSummonDoomguard_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("summon doomguard", keyString);

        }

        private void bUnendingResolve_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("unending resolve", keyString);

        }

        private void bCreateSoulwell_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("create soulwell", keyString);


        }

        private void bDemonicGateway_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("demonic gateway", keyString);
        }

        private void bRitualOfSummoning_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("ritual of summoning", keyString);
        }

        private void bDemonicCircle_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("demonic cirlce", keyString);

        }

        private void bMortalCoil_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("mortal coil", keyString);

        }

        private void bShadowfury_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("shadow fury", keyString);

        }

        private void bSoulharvest_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.addHotkey("soul harvest", keyString);

        }

        private void WarlockBaseForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }
    }
}
