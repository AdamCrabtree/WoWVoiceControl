using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl.ClassForms.Warlock
{
    static class WarlockGrammar
    {
        public static Grammar GenerateWarlockGrammar()
        {
            GrammarBuilder warlockGrammarBuilder = new GrammarBuilder();
            warlockGrammarBuilder.Append(GenerateClassAbilityGrammar(), 0, 1);
            warlockGrammarBuilder.Append(GenerateDestructionGrammar(), 0, 1);
            warlockGrammarBuilder.Append(GenerateAfflictionGrammar(), 0, 1);
            warlockGrammarBuilder.Append(GenerateDemonologyGrammar(), 0, 1);
            warlockGrammarBuilder.Append(GenericHotkeys.GenerateGenericChoices(), 0, 1);
            Grammar warlockGrammar = new Grammar(warlockGrammarBuilder);
            return warlockGrammar;
        }
        public static Choices GenerateDemonologyGrammar()
        {
            Choices AbilityCommands = new Choices();
            AbilityCommands.Add(new string[] {"shadow bolt", "hand of gul dan", "demonic empowerment", "call dreadstalkers", "doom", "demonwrath", "summon felguard", "shadowflame", "implosion", "summon darkglare", "demonbolt" });
            return AbilityCommands;
        }
        public static Choices GenerateDestructionGrammar()
        {
            Choices AbilityCommands = new Choices();
            AbilityCommands.Add(new string[] { "immolate", "incinerate", "conflagrate", "chaos bolt", "rain of fire", "havoc" });
            return AbilityCommands;
        }
        public static Choices GenerateAfflictionGrammar()
        {
            Choices AbilityCommands = new Choices();
            AbilityCommands.Add(new string[] { "corruption", "agony", "unstable affliction", "drain soul", "seed of corruption", "haunt", "howl of terror", "siphon life", "grimore of sacrifice", "soul effigy", "phantom singularity" });
            return AbilityCommands;
        }
        public static Choices GenerateClassAbilityGrammar()
        {
            Choices AbilityCommands = new Choices();
            AbilityCommands.Add(new string[] { "drain life", "summon imp", "soul leach", "create healthstone", "summon voidwalker", "fear", "soulstone", "health funnel", "eye of kilrogg", "unending breath", "summon succubus", "command demon", "banish", "life tap", "summon felhunter", "summon infernal", "enslave demon", "summon doomguard", "unending resolve", "create soulwell", "ritual of summoning", "demonic gateway", "mortal coil", "demonic circle", "shadowfury", "soul harvest", "soul conduit", "burning rush", "dark pact" });
            return AbilityCommands;
        }
    }
}
