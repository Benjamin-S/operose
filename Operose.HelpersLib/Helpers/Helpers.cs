using Operose.HelpersLib.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Operose.HelpersLib
{
    public static class Helpers
    {
        public static readonly Version OSVersion = Environment.OSVersion.Version;

        public static void CreateDirectory(string directoryPath)
        {
            if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
            {
                try
                {
                    Directory.CreateDirectory(directoryPath);
                }
                catch (Exception e)
                {
                    DebugHelper.WriteException(e);
                    MessageBox.Show(Resources.Helpers_CreateDirectoryIfNotExist_Create_Failed + "\r\n\r\n" + e, "Operose - " + Resources.Error,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void CreateDirectoryFromFilePath(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                string directoryPath = Path.GetDirectoryName(filePath);
                CreateDirectory(directoryPath);
            }
        }

        public static bool IsWindows10OrGreater(int build = -1)
        {
            return OSVersion.Major >= 10 && OSVersion.Build >= build;
        }

        public static string rtrim(string str, char c, bool invert = false)
        {
            int length = str.Length;
            if (length == 0)
            {
                return "";
            }

            // Length of suffix matching the invert condition.
            int suffixLength = 0;

            // Step through until we fail to match the invert condition.
            while (suffixLength < length)
            {
                var currChar = str[length - suffixLength - 1];
                if (currChar == c && !invert)
                {
                    suffixLength++;
                }
                else if (currChar != c && invert)
                {
                    suffixLength++;
                }
                else
                {
                    break;
                }
            }
            return str.Substring(0, length - suffixLength);
        }

        // Taken from https://stackoverflow.com/a/22368809/8640204
        public static IEnumerable<string> SplitToLines(string stringToSplit, int maximumLineLength)
        {
            var words = stringToSplit.Split(' ');
            var line = words.First();
            foreach (var word in words.Skip(1))
            {
                var test = $"{line} {word}";
                if (test.Length > maximumLineLength)
                {
                    yield return line;
                    line = word;
                }
                else
                {
                    line = test;
                }
            }
            yield return line;
        }
    }
}