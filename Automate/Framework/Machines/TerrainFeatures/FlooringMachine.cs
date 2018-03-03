using StardewValley.TerrainFeatures;

namespace Pathoschild.Stardew.Automate.Framework.Machines.Objects
{
    /// <summary>
    /// A flooring that accepts no input and provides no output.  Used only to connect other machines together.
    /// </summary>
    internal class FlooringMachine : IMachine
    {
        /// <summary>
        /// The underlying flooring object
        /// </summary>
        private readonly Flooring Floor;

        /// <summary>Construct an instance.</summary>
        /// <param name="floor">The underlying flooring object</param>
        public FlooringMachine(Flooring floor)
        {
            this.Floor = floor;
        }

        /// <summary>Get the machine's processing state.</summary>
        public MachineState GetState()
        {
            // there is no state
            return MachineState.Disabled;
        }

        /// <summary>Get the output item.</summary>
        public ITrackedStack GetOutput()
        {
            return null;
        }

        /// <summary>Provide input to the machine.</summary>
        /// <param name="input">The available items.</param>
        /// <returns>Returns whether the machine started processing an item.</returns>
        public bool SetInput(IStorage input)
        {
            return false;
        }
    }
}
