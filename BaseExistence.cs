namespace Once_Upon_A_Dog
{
    /// <summary>
    /// The base origin of objects
    /// </summary>
    interface BaseExistence
    {
        #region Properties

        /// <summary>
        /// A name of an object
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// How heavy an object
        /// </summary>
        int Weight { get; set; } 

        #endregion
    }
}
