﻿namespace Once_Upon_A_Dog
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
        /// Add <see cref="Item"/> to <see cref="Creature.Inventory"/>
        /// </summary>
        Take,
        /// <summary>
        /// Damage <see cref="Item"/>
        /// </summary>
        Kick
    }
}