using System;


namespace R5T.T0021
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RootPath : IRootPath
    {
        #region Static
        
        public static RootPath Instance { get; } = new();

        #endregion
    }
}