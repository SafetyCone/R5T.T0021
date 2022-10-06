using System;


namespace R5T.T0021
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RootedPath : IRootedPath
    {
        #region Static
        
        public static IRootedPath Instance { get; } = new RootedPath();

        #endregion
    }
}