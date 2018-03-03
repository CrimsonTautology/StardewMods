using Newtonsoft.Json;
using Pathoschild.Stardew.Common;
using StardewModdingAPI;

namespace Pathoschild.Stardew.Automate.Framework.Models
{
    /// <summary>The raw mod configuration.</summary>
    internal class ModConfig
    {
        /*********
        ** Accessors
        *********/
        /// <summary>Write more trace information to the log.</summary>
        public bool VerboseLogging { get; set; } = false;

        /// <summary>The number of ticks between each automation process (60 = once per second).</summary>
        public int AutomationInterval { get; set; } = 60;

        /// <summary>The control bindings.</summary>
        public ModConfigControls Controls { get; set; } = new ModConfigControls();

        /// <summary>
        /// Floooring IDs to use to act as a pipe between machines
        /// Floor types:
        ///     Wood Floor = 0;
        ///     Stone Floor = 1;
        ///     Weathered Floor = 2;
        ///     Crystal Floor = 3;
        ///     Straw Floor = 4;
        ///     Gravel Path = 5;
        ///     Wood Path = 6;
        ///     Crystal Path = 7;
        ///     Cobblestone Path = 8;
        ///     Stepping Stone Path = 9;
        /// </summary>
        public int[] FlooringPipes { get; set; } = { 6 };


        /*********
        ** Nested models
        *********/
        /// <summary>A set of control bindings.</summary>
        internal class ModConfigControls
        {
            /// <summary>The button which toggles the automation overlay.</summary>
            [JsonConverter(typeof(StringEnumArrayConverter))]
            public SButton[] ToggleOverlay { get; set; } = { SButton.U };
        }
    }
}
