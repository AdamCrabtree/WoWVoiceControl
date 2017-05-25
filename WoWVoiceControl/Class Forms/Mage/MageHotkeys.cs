using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl.SpecForms
{
    public class MageHotkeys
    {
        public Dictionary<string, string> mageHotkeyDictionary;
        public MageHotkeys()
        {
            this.mageHotkeyDictionary = GenericHotkeys.myDict;
        }
        public void addHotkey(String abilityNameString, String hotkeyString)
        {
            mageHotkeyDictionary.Add(abilityNameString, hotkeyString);
        }
    }
}
