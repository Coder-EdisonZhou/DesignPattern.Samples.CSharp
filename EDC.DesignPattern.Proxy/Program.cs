using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISearcher searcher = AppConfigHelper.GetProxyInstance() as ISearcher;
            if (searcher != null)
            {
                string result = searcher.DoSearch("杨过", "玉女心经");
            }

            Console.ReadKey();
        }
    }
}
