using WoWVoiceControl.ClassForms.DemonHunter.Specs;
using WoWVoiceControl.ClassForms.Warlock;
using WoWVoiceControl.ClassForms.Warlock.Specs;
using WoWVoiceControl.SpecForms;

namespace WoWVoiceControl
{
    /// <summary>
    /// Class holding singleton instances of forms
    /// </summary>
    public static class FormProvider
    {
        private static DemonHunterBaseForm demonHunterBaseForm = null;
        //  Return form if not null, else return form = new Form() -- ensures there is only ever one instance
        public static DemonHunterBaseForm DemonHunterBaseForm => demonHunterBaseForm ?? (demonHunterBaseForm = new DemonHunterBaseForm());

        private static HavocHotkeysForm havocHotkeysForm = null;
        public static HavocHotkeysForm HavocHotkeysForm(DemonHunterHotkeys keys)
        {
            // If the form is not null and is disposed then the form would have been closed. Set it to null.
            if (havocHotkeysForm != null && havocHotkeysForm.IsDisposed)
                havocHotkeysForm = null;

            return havocHotkeysForm ?? (havocHotkeysForm = new HavocHotkeysForm(keys));
        }

        private static VengeanceHotkeysForm vengeanceHotkeysForm = null;
        public static VengeanceHotkeysForm VengeanceHotkeysForm(DemonHunterHotkeys keys)
        {
            if (vengeanceHotkeysForm != null && vengeanceHotkeysForm.IsDisposed)
                vengeanceHotkeysForm = null;

            return vengeanceHotkeysForm ?? (vengeanceHotkeysForm = new VengeanceHotkeysForm(keys));
        }


        private static WarlockBaseForm warlockBaseForm = null;
        public static WarlockBaseForm WarlockBaseForm => warlockBaseForm ?? (warlockBaseForm = new WarlockBaseForm());

        private static AfflictionHotkeysForm afflictionHotkeysForm = null;
        public static AfflictionHotkeysForm AfflictionHotkeysForm(WarlockHotkeys keys)
        {
            if (afflictionHotkeysForm != null && afflictionHotkeysForm.IsDisposed)
                afflictionHotkeysForm = null;

            return afflictionHotkeysForm ?? (afflictionHotkeysForm = new AfflictionHotkeysForm(keys));
        }

        private static DemonologyHotkeysForm demonologyHotKeysForm = null;
        public static DemonologyHotkeysForm DemonologyHotkeysForm(WarlockHotkeys hotkeys)
        {
            if (demonologyHotKeysForm != null && demonologyHotKeysForm.IsDisposed)
                demonologyHotKeysForm = null;

            return demonologyHotKeysForm ?? (demonologyHotKeysForm = new DemonologyHotkeysForm(hotkeys));
        }

        private static DestructionHotkeysForm destructionHotKeysForm = null;
        public static DestructionHotkeysForm DestructionHotkeysForm(WarlockHotkeys keys)
        {
            if (destructionHotKeysForm != null && destructionHotKeysForm.IsDisposed)
                destructionHotKeysForm = null;

            return destructionHotKeysForm ?? (destructionHotKeysForm = new DestructionHotkeysForm(keys));
        }
    }
}
