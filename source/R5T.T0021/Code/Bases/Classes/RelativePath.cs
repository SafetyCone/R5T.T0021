using System;


namespace R5T.T0021
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RelativePath : IRelativePath
    {
        #region Static
        
        public static RelativePath Instance { get; } = new();

        #endregion
    }
}