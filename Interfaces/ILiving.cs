﻿using System.Collections.Generic;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// Describes behavior and properties of a living being
    /// </summary>
    public interface ILiving<TItem, TLiving> : IBaseExistence
        where TItem : INonliving
        where TLiving : ILiving<TItem, TLiving>
    {
        #region Properties

        /// <summary>
        /// True, if a creature can't eat more
        /// </summary>
        bool IsFull { get; set; }

        /// <summary>
        /// An inventory and equipped things
        /// </summary>
        List<TItem> Inventory { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Interact with other living being
        /// </summary>
        /// <param name="living">A creature to interact with</param>
        /// <param name="command">What to do with a creature</param>
        void PerformAction(TLiving creature, Command command, string words, TItem item);

        /// <summary>
        /// Interact with a thing
        /// </summary>
        /// <param name="nonliving">A thing to interact with</param>
        /// <param name="command">What to do with a thing</param>
        void PerformAction(TItem item, Command command);

        /// <summary>
        /// Execute action that is out of the basic <see cref="Command"/>s.
        /// Can't change or interact with anything
        /// </summary>
        /// <param name="action">An action to execute</param>
        void PerformComplicatedAction(string action);

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        void MakeSound(string words, int repeat);

        /// <summary>
        /// Say something with another creature
        /// </summary>
        /// <param name="words">Words to say</param>
        /// <param name="creature">Some creature you want to speak with</param>
        void MakeSound(TLiving creature, string words);

        #endregion
    }
}
