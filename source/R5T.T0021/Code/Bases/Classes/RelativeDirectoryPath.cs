using System;


namespace R5T.T0021
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RelativeDirectoryPath : IRelativeDirectoryPath
    {
        #region Static
        
        public static RelativeDirectoryPath Instance { get; } = new();

        #endregion
    }
}