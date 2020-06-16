using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Prototype
{
    /// <summary>
    /// 工作周报：具体原型类
    /// 考虑到代码可读性和易理解性，只列出部分与原型模式相关的核心代码
    /// </summary>
    [Serializable]
    public class WeeklyLog : ICloneable
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public IList<Attachment> attachmentList { get; set; }

        // v2,v3
        public WeeklyLog()
        {
            this.attachmentList = new List<Attachment>();
        }

        public object Clone()
        {
            // v1
            //WeeklyLog obj = new WeeklyLog();
            //obj.Name = this.Name;
            //obj.Date = this.Date;
            //obj.Content = this.Content;
            // v2 -- shallow copy
            //obj.attachmentList = this.attachmentList;
            //return obj;
            // v3 -- deep copy
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, this);
            ms.Position = 0;
            return bf.Deserialize(ms);
        }
    }
}
