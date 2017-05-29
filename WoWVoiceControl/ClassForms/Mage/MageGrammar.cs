using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl.SpecForms
{
    static class MageGrammar
    {

        public static Grammar GenerateMageGrammar()
        {
            GrammarBuilder mageGrammarBuilder = new GrammarBuilder();
            mageGrammarBuilder.Append(GenerateArcaneGrammar(),0,1);
            mageGrammarBuilder.Append(GenerateFireGrammar(),0,1);
            mageGrammarBuilder.Append(GenerateFrostGrammar(), 0, 1);
            mageGrammarBuilder.Append(GenerateClassAbilityGrammar(), 0, 1);
            mageGrammarBuilder.Append(GenericHotkeys.GenerateGenericChoices(), 0, 1);
            Grammar mageGrammar = new Grammar(mageGrammarBuilder);
            return mageGrammar;
        }
        public static Choices GenerateArcaneGrammar()
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "arcane barrage", "arcane blast", "arcane missiles", "displacement", "prismatic barrier", "arcane explosion", "presence of mind", "slow", "evocation", "arcane power", "greater invisibility", "mastery savant", "arcane familiar", "mirror image", "rune of power", "supernova", "charged up", "nether tempest", "arcane orb" });
            return commands;
        }
        public static Choices GenerateFireGrammar()
        {
            Choices commands = new Choices();
           commands.Add(new string[] { "fireball", "pyroblast", "dragons breath", "fire blast", "scorch", "flame strike", "invisibility", "combustion", "blazing barrier", "mirror image", "shimmer", "blast wave", "rune of power", "ring of frost", "living bomb", "meteor", "cinderstorm" });
            return commands;
        }
        public static Choices GenerateFrostGrammar()
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "frostbolt", "ice lance", "summon water elemental", "flurry", "ice floes", "cone of cold", "icy veins", "blizzard", "ice barrier", "invisibility", "cold snap", "frozen orb", "ray of frost", "ice nova", "frozen touch", "frost bomb", "glacial spike", "comet storm" });
            return commands;
        }
        public static Choices GenerateClassAbilityGrammar()
        {
            Choices commands = new Choices();
            commands.Add("frost nova", "blink", "polymorph", "conjure refreshment", "ice block", "slow fall", "counterspell", "time warp", "spellsteal");
            return commands;
        }
    }
}
