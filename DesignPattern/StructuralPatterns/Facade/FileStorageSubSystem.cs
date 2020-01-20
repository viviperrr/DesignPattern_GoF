using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralPatterns.Facade
{
    public class FileStorageSubSystem
    {
        public byte[] GetFile(string filePath)
        {
            // Connect FileServer
            byte[] fileData = new byte[] { 0x00, 0xa1, 0x81, 0x99 };
            return fileData;
        }
    }
}
