using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    /// <summary>
    /// 访问者
    /// </summary>
    public abstract class Visitor
    {
        public virtual void Visit(ElementA element)
        {
            if (element == null) return;

           //DoSomething to element
        }


        public virtual void Visit(ElementB element)
        {
            if (element == null) return;

            //DoSomething to element
        }
    }

    public class ConcreteVisitor :Visitor
    {

        public override void Visit(ElementA element)
        {
            if (element == null) return;

            //DoSomething to elementA
        }


        public override void Visit(ElementB element)
        {
            if (element == null) return;

            //DoSomething to elementB
        }

    }


}
