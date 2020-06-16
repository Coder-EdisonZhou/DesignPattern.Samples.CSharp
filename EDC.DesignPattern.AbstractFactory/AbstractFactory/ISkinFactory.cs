using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.AbstractFactory
{
    public interface ISkinFactory
    {
        IButton CreateButton();
        ITextField CreateTextField();
        IComboBox CreateComboBox();
    }
}
