using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl
{
    static class GenerateKeyStrings
    {
        public static string generateKeyString(string keyString)
        {
            switch (keyString)
            {
                case "!":
                    return "+1";
                case "@":
                    return "+2";
                case "#":
                    return "+3";
                case "$":
                    return "4";
                case "%":
                    return "5";
                case "^":
                    return "6";
                case "&":
                    return "7";
                case "*":
                    return "8";
                case "(":
                    return "9";
                case ")":
                    return "0";
            }
            return keyString;
        }
    }
}
