using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace DesignPattern.Decorator5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream stream = new MemoryStream(new byte[] { 97, 98, 99, 100 });
            stream = new BufferedStream(stream);
            stream = new CryptoStream(stream, new AesManaged().CreateEncryptor(), CryptoStreamMode.Write);
            stream = new GZipStream(stream, CompressionMode.Compress, true);
        }
    }
}
