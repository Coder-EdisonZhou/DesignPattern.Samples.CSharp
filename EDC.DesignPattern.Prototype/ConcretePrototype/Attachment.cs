using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Prototype
{
    [Serializable]
    public class Attachment
    {
        public string Name { get; set; }

        public void Download()
        {
            Console.WriteLine("下载附件，文件名为：{0}", this.Name);
        }
    }
}
