namespace Once_Upon_A_Dog
{
    /// <summary>
    /// An interface for things
    /// </summary>
    public interface INonliving : IBaseExistence
    {
        #region Properties

        /// <summary>
        /// True if a living can eat this
        /// </summary>
        bool IsFood { get; set; }

        #endregion
    }
}