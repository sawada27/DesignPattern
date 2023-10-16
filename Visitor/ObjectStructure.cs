using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{

    /// <summary>
    /// 集合中心 提供一个Accept方法决定接受具体的访问者
    /// </summary>
    public class ObjectStructure
    {

            private List<Element> list = new List<Element>();

            public void Accept(Visitor visitor)
            {
                list.ForEach(t=>t.Accept(visitor));
            }

            public void Add(Element element)
            {
                list.Add(element);
            }
        


    }
}
