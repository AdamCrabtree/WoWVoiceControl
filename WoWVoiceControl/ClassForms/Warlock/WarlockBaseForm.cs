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
using WoWVoiceControl.ClassForms.Warlock;
using WoWVoiceControl.ClassForms.Warlock.Specs;

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

            hotkeyList = new WarlockHotkeys();
        }
       
        private void bAffliction_Click(object sender, EventArgs e)
        {
            //AfflictionHotkeysForm afflictionForm = new AfflictionHotkeysForm();
            //afflictionForm.Show();
            //this.Hide();
        }

        private void bDemonology_Click(object sender, EventArgs e)
        {
            FormProvider.DemonologyHotkeysForm(hotkeyList).Show();

            this.Hide();
        }

        private void bDestruction_Click(object sender, EventArgs e)
        {
            FormProvider.DestructionHotkeysForm(hotkeyList).Show();

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
                hotkeyList.ClassAbilityDictionary.TryGetValue(e.Result.Text, out key);
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
            hotkeyList.AddHotKey("drain life", keyString);
        }

        private void bSummonImp_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("summon imp", keyString);

        }

        private void bSoulLeach_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("soul leach", keyString);


        }

        private void bCreateHealthstone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("create healthstone", keyString);

        }

        private void bSummonVoidwalker_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("summon voidwalker", keyString);


        }

        private void bFear_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("fear", keyString);

        }

        private void bSoulstone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("soulstone", keyString);

        }

        private void bHealthFunnel_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("health funnel", keyString);


        }

        private void bEyeOfKilrogg_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("eye of kilrogg", keyString);

        }

        private void bUnendingBreath_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("unending breath", keyString);

        }

        private void bSummonSuccubus_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("summon succubus", keyString);

        }

        private void bCommandDemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("command demon", keyString);

        }

        private void bBanish_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("banish", keyString);

        }

        private void bLifeTap_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("life tap", keyString);

        }

        private void bSummonFelhunter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("summon felhunter", keyString);

        }

        private void bSummonInfernal_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("summon infernal", keyString);


        }

        private void bEnslaveDemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("enslave demon", keyString);


        }

        private void bSummonDoomguard_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("summon doomguard", keyString);

        }

        private void bUnendingResolve_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("unending resolve", keyString);

        }

        private void bCreateSoulwell_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("create soulwell", keyString);


        }

        private void bDemonicGateway_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("demonic gateway", keyString);
        }

        private void bRitualOfSummoning_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("ritual of summoning", keyString);
        }

        private void bDemonicCircle_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("demonic circle", keyString);

        }

        private void bMortalCoil_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("mortal coil", keyString);

        }

        private void bShadowfury_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("shadow fury", keyString);

        }

        private void bSoulharvest_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyString = e.KeyChar.ToString();
            keyString = GenerateKeyStrings.generateKeyString(keyString);
            hotkeyList.AddHotKey("soul harvest", keyString);

        }

        private void WarlockBaseForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }
    }
}
