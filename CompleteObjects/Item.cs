﻿using System;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// Nonliving objects
    /// </summary>
    public class Item : INonliving
    {
        #region Private Members

        /// <summary>
        /// A weight of a thing, or
        /// a weight and calories (at the same time) if it's food
        /// </summary>
        private int mWeight;

        #endregion

        #region Public Properties

        /// <summary>
        /// A name of a food
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A weight of a thing, or
        /// a weight and calories (at the same time) if it's food
        /// </summary>
        public int Weight
        {
            get
            {
                return IsDestroyed ? 0 : mWeight;
            }
            set
            {
                // Weight can't be negative
                if (value < 0)
                    throw new System.ArgumentException("Weight should be more than 0");
                // If it has 0 weight, a thing is destroyed
                else if (value == 0)
                {
                    // TODO: Restrict use of destroyed item
                    Console.WriteLine("{0} destroyed, can't use it",Name);
                    // TODO: Make a proper way of disposing
                    IsDestroyed = true;
                }

                // Set new value
                mWeight = value;
            }
        }

        /// <summary>
        /// True, if you can break an item
        /// </summary>
        public bool CanBreak { get; set; } = false;

        /// <summary>
        /// True if a living can eat this
        /// </summary>
        public bool IsFood { get; set; } = false;

        /// <summary>
        /// Indicates if an item can't be used
        /// </summary>
        public bool IsDestroyed { get; private set; } = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">A name of a food</param>
        /// <param name="weight">A sum of a weight and calories of a food</param>
        public Item(string name, int weight)
        {
            // Set properties
            Name = name;
            Weight = weight;
        }

        /// <summary>
        /// Default constructor with break-ability specification
        /// </summary>
        /// <param name="name">A name of a food</param>
        /// <param name="weight">A sum of a weight and calories of a food</param>
        /// <param name="canBreak">Change break-ability</param>
        public Item(string name, int weight, bool canBreak = false, bool isFood = false)
        {
            // Set properties
            Name = name;
            Weight = weight;
            CanBreak = canBreak;
            IsFood = isFood;
        }

        #endregion
    }
}