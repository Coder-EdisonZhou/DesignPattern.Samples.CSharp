using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Prototype
{
    public class FAR : OfficeDocument
    {
        public OfficeDocument Clone()
        {
            return new FAR();
        }

        public void Display()
        {
            Console.WriteLine("<<可行性分析报告>>");
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
