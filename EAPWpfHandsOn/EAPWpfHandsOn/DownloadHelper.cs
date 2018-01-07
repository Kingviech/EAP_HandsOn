using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EAPWpfHandsOn
{
    public class DownloadHelper
    {
        /// <summary>
        /// Dictionary for filename filesize mapping for the example
        /// </summary>
        private Dictionary<string, int> fileDefinitions = new Dictionary<string, int>
        {
            { "HugeFile.zip", 7 },
            { "TotallyLegal.iso", 13 },
            { "NiceTool.exe", 3 },
            { "10HR_Helene_Fischer.mp3", 9 },
            { "Exceptional_File.txt", 2 }
        };        

        /// <summary>
        /// Returns file size
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public int Download(string fileName)
        {
            if (fileName.Equals("Exceptional_File.txt")) throw new Exception("Oops, the requested file does not exist anymore.");

            int fileSize = fileDefinitions[fileName];
            for (int i = 0; i < fileSize; i++)
                DownloadChunk();
            return fileSize;
        }

        private void DownloadChunk()
        {
            Thread.Sleep(1000);
        }
    }
}
