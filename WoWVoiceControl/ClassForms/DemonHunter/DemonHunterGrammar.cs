using System.Speech.Recognition;

namespace WoWVoiceControl.SpecForms
{
    static class DemonHunterGrammar
    {

        public static string[] BaseDemonHunterAbilities => new[] { "Consume Magic", "Glide", "Imprison", "Metamorphosis", "Spectral Sight", "Throw Glaive" };

        public static string[] VengeanceDemonHunterAbilities => new[] { "Soul Barrier", "Fel Devastation", "Spirit Bomb", "Fel Eruption", "Sigil of Chains", "Sigil of Misery", "Fracture", "Felblade", "Sigil of Silence", "Demon Spikes", "Fiery Brand", "Shear", "Sigil of Flame", "Soul Cleave", "Immolation Aura" };

        public static string[] HavocDemonHunterAbilities => new[] { "Fel Barrage", "Fel Eruption", "Nemesis", "Netherwalk", "Chaos Strike", "Felblade", "Blade Dance", "Blur", "Chaos Nova", "Eye Beam", "Fel Rush", "Soul Carver", "Vengeful Retreat", "Fury of the Illidari", "Demon's Bite" };

        public static Grammar GenerateDemonHunterGrammar()
        {
            GrammarBuilder demonHunterGrammarBuilder = new GrammarBuilder();
            demonHunterGrammarBuilder.Append(GenerateHavocGrammar(), 0, 1);
            demonHunterGrammarBuilder.Append(GenerateVengeanceGrammar(), 0, 1);
            demonHunterGrammarBuilder.Append(GenerateBaseDemonHunterGrammar(), 0, 1);
            demonHunterGrammarBuilder.Append(GenericHotkeys.GenerateGenericChoices(), 0, 1);
            Grammar DHGrammar = new Grammar(demonHunterGrammarBuilder);
            return DHGrammar;
        }

        public static Choices GenerateHavocGrammar()
        {
            Choices commands = new Choices();

            commands.Add(HavocDemonHunterAbilities);

            return commands;
        }

        public static Choices GenerateVengeanceGrammar()
        {
            Choices commands = new Choices();

            commands.Add(VengeanceDemonHunterAbilities); // Infernal Strike - targeted ability. Not Added

            return commands;
        }

        public static Choices GenerateBaseDemonHunterGrammar()
        {
            Choices commands = new Choices();

            commands.Add(BaseDemonHunterAbilities);

            return commands;
        }
    }
}
