using System.Diagnostics.Metrics;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  组合模式   结构型模式 
           应用场景： 流程业务，各司其职，就可以考虑责任链模式

             优点:组合模式使得客户端代码可以一致地处理单个对象和组合对象，无须关心自己处理的是单个对象，还是组合对象，这简化了客户端代码；
                    更容易在组合体内加入新的对象，客户端不会因为加入了新的对象而更改源代码，满足“开闭原则”；

             缺点：设计较复杂，客户端需要花更多时间理清类之间的层次关系；
                    不容易限制容器中的构件；
                    不容易用继承的方法来增加构件的新功能；

             速记：树结构 根 枝 叶
          */
        
            var organzation = new Department("CEO", "A总");
            var developDepart = new Department("研发部经理", "A经理");

            //A总下的研发部
            organzation.Add(developDepart);

            var depart = new Department("项目组长", "A组长");
            //研发部下的项目组长
            developDepart.Add(depart);

            var staffA = new Staff { Position = "开发工程师", Name = "A开发" };
            var staffB = new Staff { Position = "开发工程师", Name = "B开发" };

            //组长下的员工
            depart.Add(staffA);
            depart.Add(staffB);
    

            Console.WriteLine("组合模式：从上往下遍历");
            DisplayStructure(organzation);
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.WriteLine("组合模式：从下往上遍历");
            FindParent(staffA);
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }


        /// <summary>
        ///     正序排序
        /// </summary>
        /// <param name="org"></param>
        private static void DisplayStructure(Organization org)
        {
            if (org.Parent == null)
                org.Display();

            var departMent = (Department)org;

            foreach (var depart in departMent.GetDepartmentMembers())
            {
                depart.Display();
                if (!(depart is Staff))
                    DisplayStructure((Department)depart);
            }
        }

        /// <summary>
        ///     倒序排序
        /// </summary>
        /// <param name="member"></param>
        private static void FindParent(Organization member)
        {
            member.Display();
            while (member.Parent != null)
            {
                member.Parent.Display();
                member = member.Parent;
            }
        }
    }
}