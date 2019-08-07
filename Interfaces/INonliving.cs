namespace Once_Upon_A_Dog
{
    /// <summary>
    /// An interface for things
    /// </summary>
    interface INonliving : IBaseExistence
    {
        #region Properties

        /// <summary>
        /// True, if you can destroy a thing with interaction
        /// </summary>
        bool CanBreak { get; set; }

        #endregion
    }
}