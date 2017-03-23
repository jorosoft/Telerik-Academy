namespace CohesionAndCoupling.Common
{
    using System;
    
    public static class FileManager
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = GetFileNameLastDotIndex(fileName);
            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = GetFileNameLastDotIndex(fileName);
            string fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            return fileNameWithoutExtension;
        }

        private static int GetFileNameLastDotIndex(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("Correct filename must be passed!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException($"Incorrect file name: {fileName}");
            }

            return indexOfLastDot;
        }
    }
}
