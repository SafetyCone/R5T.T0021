using System;
using System.IO;

using R5T.Magyar.IO;

using R5T.T0021;


namespace System
{
    public static class IDirectoryPathExtensions
    {
        public static void EnsureDirectoryPathExists(this IDirectoryPath _,
            string directoryPath)
        {
            DirectoryHelper.CreateDirectoryOkIfExists(directoryPath);
        }

        public static void EnsureDirectoryPathsExist(this IDirectoryPath directoryPath,
            params string[] directoryPaths)
        {
            foreach (var directoryPathValue in directoryPaths)
            {
                directoryPath.EnsureDirectoryPathExists(directoryPathValue);
            }
        }
    }
}
