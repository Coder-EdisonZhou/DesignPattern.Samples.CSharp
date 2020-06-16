using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ActorBuilder builder = (ActorBuilder)AppConfigHelper.GetConcreteBuilderInstance();
            ActorController director = new ActorController();
            Actor actor = director.Construct(builder);

            Console.WriteLine("角色类型：{0}", actor.Type);
            Console.WriteLine("角色性别：{0}", actor.Sex);
            Console.WriteLine("角色面容：{0}", actor.Face);
            Console.WriteLine("角色服装：{0}", actor.Costume);
            Console.WriteLine("角色发型：{0}", actor.HairStyle);

            Console.ReadKey();
        }
    }
}
