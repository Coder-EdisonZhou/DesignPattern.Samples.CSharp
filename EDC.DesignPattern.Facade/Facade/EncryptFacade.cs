using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Facade
{
    public class EncryptFacade
    {
        private FileReader reader;
        private CipherMachine cipher;
        private FileWriter writer;

        public EncryptFacade()
        {
            reader = new FileReader();
            cipher = new CipherMachine();
            writer = new FileWriter();
        }

        public void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            string plainStr = reader.Read(fileNameSrc);
            string encryptedStr = cipher.Encrypt(plainStr);
            writer.Write(encryptedStr, fileNameDes);
        }
    }
}
