using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl.Class_Forms.Warlock
{
    public class WarlockHotkeys
    {
        public Dictionary<string, string> WarlockHotkeyDictionary;
        public WarlockHotkeys()
        {
            this.WarlockHotkeyDictionary = GenericHotkeys.myDict;
        }
        public void addHotkey(String abilityNameString, String hotkeyString)
        {
            try
            {
                WarlockHotkeyDictionary.Add(abilityNameString, hotkeyString);
            }
            catch
            {
                SpeechSynthesizer errorSynth = new SpeechSynthesizer();
                errorSynth.SpeakAsync("ability already bound.");
            }
        }
    }
}
