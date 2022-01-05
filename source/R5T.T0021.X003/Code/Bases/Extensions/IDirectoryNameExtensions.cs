using System;

using R5T.T0021;

using R5T.T0021.X003;


namespace System
{
    public static class IDirectoryNameExtensions
    {
        /// <summary>
        /// Returns '.', which at the command line stands for the current directory.
        /// </summary>
        public static string CurrentDirectory(this IDirectoryName _)
        {
            return DirectoryNames.CurrentDirectory;
        }

        public static bool IsCurrentDirectory(this IDirectoryName _,
            string directoryName)
        {
            var output = directoryName == _.CurrentDirectory();
            return output;
        }

        public static bool IsParentDirectory(this IDirectoryName _,
            string directoryName)
        {
            var output = directoryName == _.ParentDirectory();
            return output;
        }

        /// <summary>
        /// Returns '..', which at the command line stands for the parent directory of the current directory.
        /// </summary>
        public static string ParentDirectory(this IDirectoryName _)
        {
            return DirectoryNames.ParentDirectory;
        }
    }
}