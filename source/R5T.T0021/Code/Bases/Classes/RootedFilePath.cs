using System;


namespace R5T.T0021
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RootedFilePath : IRootedFilePath
    {
        #region Static
        
        public static IRootedFilePath Instance { get; } = new RootedFilePath();

        #endregion
    }
}