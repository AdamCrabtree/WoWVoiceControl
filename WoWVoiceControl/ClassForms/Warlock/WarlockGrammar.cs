using System.Speech.Recognition;

namespace WoWVoiceControl.ClassForms.Warlock
{
    static class WarlockGrammar
    {

        public static string[] BaseWarlockAbilities => new[] { "Drain Life", "Summon Imp", "Soul Leech", "Create Healthstone", "Summon Voidwalker", "Fear", "Soulstone", "Health Funnel", "Eye of Kilrogg", "Unending Breath", "Summon Succubus", "Command Demon", "Banish","Life Tap", "Summon Felhunter", "Summon Infernal", "Enslave Demon", "Summon Doomguard", "Unending Resolve", "Create Soulwell", "Ritual of Summoning", "Demonic Gateway", "Mortal Coil", "Demonic Circle", "Shadowfury", "Soul Harvest", "Soul Conduit", "Burning Rush", "Dark Pact" };
        public static string[] AfflictionWarlockAbilities => new[] { "Corruption", "Agony", "Unstable Affliction", "Drain Soul", "Seed of Corruption", "Haunt", "Howl of Terror", "Siphon Life", "Grimoire of Sacrifice", "Soul Effigy", "Phantom Singularity" };
        public static string[] DemonologyWarlockAbilities => new[] { "Shadow Bolt", "Hand of Gul'Dan", "Demonic Empowerment", "Call Dreadstalkers", "Doom", "Demonwrath", "Summon Felguard", "Shadowflame", "Implosion", "Summon Darkglare", "Demonbolt" };
        public static string[] DestructionWarlockAbilities => new[] { "Immolate", "Incinerate", "Conflagrate", "Chaos Bolt", "Rain of Fire", "Havoc" };

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
            AbilityCommands.Add(DemonologyWarlockAbilities);
            return AbilityCommands;
        }
        public static Choices GenerateDestructionGrammar()
        {
            Choices AbilityCommands = new Choices();
            AbilityCommands.Add(DestructionWarlockAbilities);
            return AbilityCommands;
        }
        public static Choices GenerateAfflictionGrammar()
        {
            Choices AbilityCommands = new Choices();
            AbilityCommands.Add(AfflictionWarlockAbilities);
            return AbilityCommands;
        }
        public static Choices GenerateClassAbilityGrammar()
        {
            Choices AbilityCommands = new Choices();
            AbilityCommands.Add(BaseWarlockAbilities);
            return AbilityCommands;
        }
    }
}
