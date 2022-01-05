using System;


namespace R5T.T0021
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Path : IPath
    {
        #region Static
        
        public static Path Instance { get; } = new();

        #endregion
    }
}