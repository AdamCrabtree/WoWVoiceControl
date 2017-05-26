using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl
{
    public static class GenericHotkeys
    {
        public static Dictionary<String, String> myDict = new Dictionary<string, string>();
        public static Choices GenerateGenericChoices()
        {
            Choices genericChoices = new Choices("auto run", "eat", "target", "mount");
            return genericChoices;
        }
    }
}
