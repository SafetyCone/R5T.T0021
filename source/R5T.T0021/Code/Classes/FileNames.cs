using System;


namespace R5T.T0021
{
    /// <summary>
    /// Simple implementation of <see cref="IFileNames"/>.
    /// Non-static class to be used as an extension method base for file names.
    /// </summary>
    public class FileNames : IFileNames
    {
        #region Static

        public static FileNames Instance { get; } = new FileNames();

        #endregion
    }
}
