using System;
using System.ComponentModel;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// Nonliving objects
    /// </summary>
    public class Item : INonliving, INotifyPropertyChanged
    {
        #region Public Events

        /// <summary>
        /// Fired when property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

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
            get => mWeight;
            set
            {
                // If weight lower than 0
                if (value <= 0)
                {
                    // TODO: Need proper message, for food and not food
                    if(!IsFood)
                        // Item destroyed
                        Console.WriteLine($"{Name} destroyed, can't use it");

                    // fire 
                    OnPropertyChanged("Weight");
                }

                // Set new value
                mWeight = value;
            }
        }

        /// <summary>
        /// True if a living can eat this
        /// </summary>
        public bool IsFood { get; set; } = false;


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
        public Item(string name, int weight, bool isFood = false)
        {
            // Set properties
            Name = name;
            Weight = weight;
            IsFood = isFood;
        }

        #endregion

        #region Event Methods

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        } 

        #endregion
    }
}