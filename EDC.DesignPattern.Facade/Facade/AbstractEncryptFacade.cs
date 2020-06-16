using System;

namespace EDC.DesignPattern.Facade
{
    /// <summary>
    /// 抽象外观类
    /// </summary>
    public abstract class AbstractEncryptFacade
    {
        public abstract void FileEncrypt(string fileNameSrc, string fileNameDes);
    }
}
