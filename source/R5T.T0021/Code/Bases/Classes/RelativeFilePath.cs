using System;


namespace R5T.T0021
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RelativeFilePath : IRelativeFilePath
    {
        #region Static
        
        public static IRelativeFilePath Instance { get; } = new RelativeFilePath();

        #endregion
    }
}