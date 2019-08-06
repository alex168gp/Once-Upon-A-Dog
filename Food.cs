namespace Once_Upon_A_Dog
{
    public class Food : INonliving
    {
        #region Private Members

        /// <summary>
        /// A sum of a weight and calories of a food
        /// </summary>
        private int mWeight;

        #endregion

        #region Public Properties

        /// <summary>
        /// True, if you can mess up food
        /// </summary>
        public bool CanBreak { get; set; } = false;

        /// <summary>
        /// A name of a food
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A sum of a weight and calories of a food
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

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">A name of a food</param>
        /// <param name="weight">A sum of a weight and calories of a food</param>
        public Food(string name, int weight)
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
        public Food(string name, int weight, bool canBreak)
        {
            // Set properties
            Name = name;
            Weight = weight;
            CanBreak = canBreak;
        }

        #endregion
    }
}