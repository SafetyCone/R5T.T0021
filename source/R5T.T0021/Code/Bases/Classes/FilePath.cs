using System;


namespace R5T.T0021
{
    public class FilePath : IFilePath
    {
        #region Static

        public static IFilePath Instance { get; } = new FilePath();

        #endregion
    }
}
