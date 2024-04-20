using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Threading;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace TGMTcs
{
    public class TGMTfile
    {

        public static void MoveFileAsync(string sourceFile, string destFile)
        {
            var t = new Thread(() => File.Move(sourceFile, destFile));
            t.Start();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string CorrectPath(string path)
        {
            if (path[path.Length - 1] != '\\')
            {
                path += '\\';
            }
            return path;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void MoveFileToRecycleBin(string filePath)
        {
            if (!File.Exists(filePath))
                return;
            FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool IsFileLocked(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }
    }
}
