using System;


namespace R5T.T0021
{
    public class DirectoryPath : IDirectoryPath
    {
        #region Static

        public static IDirectoryPath Instance { get; } = new DirectoryPath();

        #endregion
    }
}
