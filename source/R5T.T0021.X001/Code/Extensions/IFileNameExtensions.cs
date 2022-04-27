using System;

using R5T.Magyar;

using R5T.T0021;


namespace System
{
    public static class IFileNameExtensions
    {
        public static string GetFileName(this IFileName _,
            string fileNameStem,
            string fileExtension,
            string fileExtensionSeparator)
        {
            var output = $"{fileNameStem}{fileExtensionSeparator}{fileExtension}";
            return output;
        }

        public static string GetFileName(this IFileName fileName,
            string fileNameStem,
            string fileExtension)
        {
            var output = fileName.GetFileName(fileNameStem, fileExtension, Strings.Period);
            return output;
        }
    }
}
