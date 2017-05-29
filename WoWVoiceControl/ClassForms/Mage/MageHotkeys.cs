using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace WoWVoiceControl.SpecForms
{
    public class MageHotkeys
    {
        public Dictionary<string, string> mageHotkeyDictionary;
        public MageHotkeys()
        {
            this.mageHotkeyDictionary = GenericHotkeys.GenericKeys;
        }
        public void addHotkey(String abilityNameString, String hotkeyString)
        {
            try
            {
                mageHotkeyDictionary.Add(abilityNameString, hotkeyString);
            }
            catch
            {
                SpeechSynthesizer errorSynth = new SpeechSynthesizer();
                errorSynth.SpeakAsync("ability already bound.");
            }
        }
    }
}
