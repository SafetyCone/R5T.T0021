using System;


namespace R5T.T0021
{
    public class DirectoryName : IDirectoryName
    {
        #region Static

        public static IDirectoryName Instance { get; } = new DirectoryName();

        #endregion
    }
}
