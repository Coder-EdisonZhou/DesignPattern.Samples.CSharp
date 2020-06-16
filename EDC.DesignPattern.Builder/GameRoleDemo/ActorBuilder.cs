using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Builder
{
    /// <summary>
    /// 角色建造器 ： 抽象建造者
    /// </summary>
    public abstract class ActorBuilder
    {
        protected Actor actor = new Actor();

        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairStyle();

        // 工厂方法 ： 返回一个完整的游戏角色对象
        public Actor CreateActor()
        {
            return actor;
        }
    }
}
