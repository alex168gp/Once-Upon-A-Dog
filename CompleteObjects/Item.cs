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
            get => mWeight;
            set
            {
                // Weight can't be negative
                if (value < 0)
                    throw new System.ArgumentException("Weight should be more than or equal 0");

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
        public Item(string name, int weight, bool canBreak)
        {
            // Set properties
            Name = name;
            Weight = weight;
            CanBreak = canBreak;
        }

        #endregion
    }
}