using Operose.HelpersLib.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Operose.HelpersLib
{
    class Helpers
    {
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
                    MessageBox.Show(Resources.Helpers_CreateDirectoryIfNotExist_Create_Failed + "\r\n\r\n" + e, "ShareX - " + Resources.Error,
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
    }
}
