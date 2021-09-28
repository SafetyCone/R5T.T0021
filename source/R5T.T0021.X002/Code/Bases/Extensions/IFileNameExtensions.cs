using System;

using R5T.T0021;
using R5T.T0021.X002;


namespace System
{
    public static class IFileNameExtensions
    {
        public static string GitIgnore(this IFileName _)
        {
            return FileNames.GitIgnore;
        }
    }
}