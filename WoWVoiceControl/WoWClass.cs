using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl
{
    public class WoWClass
    {
        private Dictionary<string, string> classAbilityDictionary;

        public WoWClass()
        {
            classAbilityDictionary = GenericHotkeys.GenericKeys;
        }

        public IReadOnlyDictionary<string, string> ClassAbilityDictionary => classAbilityDictionary;

        public void AddHotKey(string abilityName, string hotKeyString)
        {
            try
            {
               classAbilityDictionary.Add(abilityName, hotKeyString);
            }
            catch
            {
                SpeechSynthesizer errorSynth = new SpeechSynthesizer();
                errorSynth.SpeakAsync("ability already bound.");
            }
        }
    }
}
