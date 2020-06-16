using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Image image = (Image) AppConfigHelper.GetImageInstance();
            ImageImplementor imageImpl = (ImageImplementor)AppConfigHelper.GetEnvInstance();

            image.SetImageImplementor(imageImpl);
            image.ParstFile("小龙女");

            Console.ReadKey();
        }
    }
}
