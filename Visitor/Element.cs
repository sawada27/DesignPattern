using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{

    /// <summary>
    /// 抽象元素 (实体抽象)
    /// </summary>
    public abstract class Element
    {

        public virtual void Accept(Visitor visitor)
        {

            //这里是访问者访问元素的地方
        }


    }

    public class ElementA : Element
    {

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }


    public class ElementB : Element
    {

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }


}
