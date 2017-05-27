using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace WoWVoiceControl.SpecForms
{
    static class DHGrammar
    {

        public static Grammar GenerateDHGrammar()
        {
            GrammarBuilder DHGrammarBuilder = new GrammarBuilder();
            DHGrammarBuilder.Append(GenerateHavocGrammar(),0,1);
            DHGrammarBuilder.Append(GenerateVengeanceGrammar(),0,1);
            DHGrammarBuilder.Append(GenerateClassAbilityGrammar(), 0, 1);
            DHGrammarBuilder.Append(GenericHotkeys.GenerateGenericChoices(), 0, 1);
            Grammar DHGrammar = new Grammar(DHGrammarBuilder);
            return DHGrammar;
        }
        public static Choices GenerateHavocGrammar()
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "Fel Barrage", "Fel Eruption", "Nemesis", "Netherwalk", "Chaos Strike", "Felblade", "Blade Dance", "Blur", "Chaos Nova", "Eye Beam", "Fel Rush", "Soul Carver", "Vengeful Retreat", "Fury of the Illidari", "Demon\'s Bite" });
            return commands;
        }
        public static Choices GenerateVengeanceGrammar()
        {
            Choices commands = new Choices();
           commands.Add(new string[] { "Soul Barrier", "Fel Devastation", "Spirit Bomb", "Fel Eruption", "Sigil of Chains", "Sigil of Misery", "Fracture", "Felblade", "Sigil of Silence", "Demon Spikes", "Fiery Brand", "Shear", "Sigil of Flame", "Soul Cleave", "Immolation Aura" }); // Infernal Strike - targeted ability. Not Added
            return commands;
        }
        public static Choices GenerateClassAbilityGrammar()
        {
            Choices commands = new Choices();
            commands.Add("Consume Magic", "Glide", "Imprison", "Metamorphosis", "Spectral Sight", "Throw Glaive");
            return commands;
        }
    }
}
