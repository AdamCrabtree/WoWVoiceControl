using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl.SpecForms
{
    public class DHHotkeys
    {
        public Dictionary<string, string> DHHotkeyDictionary;
        public DHHotkeys()
        {
            this.DHHotkeyDictionary = GenericHotkeys.myDict;
        }
        public void addHotkey(String abilityNameString, String hotkeyString)
        {
            try
            {
                DHHotkeyDictionary.Add(abilityNameString, hotkeyString);
            }
            catch
            {
                SpeechSynthesizer errorSynth = new SpeechSynthesizer();
                errorSynth.SpeakAsync("ability already bound.");
            }

        }
    }
    }
}
