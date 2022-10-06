using System;


namespace R5T.T0021
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RootedDirectoryPath : IRootedDirectoryPath
    {
        #region Static
        
        public static IRootedDirectoryPath Instance { get; } = new RootedDirectoryPath();

        #endregion
    }
}