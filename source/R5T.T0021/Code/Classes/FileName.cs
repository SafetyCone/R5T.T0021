using System;


namespace R5T.T0021
{
    /// <summary>
    /// Simple implementation of <see cref="IFileName"/>.
    /// Non-static class to be used as an extension method base for file names.
    /// </summary>
    public class FileName : IFileName
    {
        #region Static

        public static FileName Instance { get; } = new();

        #endregion
    }
}
