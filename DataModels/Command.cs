namespace Once_Upon_A_Dog
{
    /// <summary>
    /// Actions that can be used by creatures
    /// </summary>
    public enum Command
    {
        /// <summary>
        /// A command to eat food
        /// </summary>
        Eat,
        /// <summary>
        /// Say something, maybe predetermined for story progress
        /// </summary>
        Talk,
        /// <summary>
        /// Add item to inventory
        /// </summary>
        Take,
        /// <summary>
        /// TODO: move item from one <see cref="ILiving.Inventory"/> to another
        /// </summary>
        Give,
        /// <summary>
        /// TODO: damage item
        /// </summary>
        Kick
    }
}