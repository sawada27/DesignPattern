using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 组织架构 (根 公共方法)
    /// </summary>
    public abstract class Organization
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 直接上级
        /// </summary>
        public Organization Parent { get; set; }


        public void Display()
        {
            var basicInfo = $"姓名：{Name},职位：{Position}";
            var parentInfo = Parent == null
                ? ""
                : $"，直接上级：『姓名：{Parent.Name},职位：{Parent.Position}』";
            Console.WriteLine(basicInfo + parentInfo);
        }
    }

    /// <summary>
    ///  主管  分支（树枝）节点
    /// </summary>
    public class Department : Organization
    {
        private readonly List<Organization> _organizationInfo = new List<Organization>();

        public Department(string departmentName, string charge)
        {
            Position = departmentName;
            Name = charge;
        }

        public void Add(Organization org)
        {
            _organizationInfo.Add(org);
            org.Parent = this;
        }

        public void Remove(Organization org)
        {
            _organizationInfo.Remove(org);
        }

        public List<Organization> GetDepartmentMembers()
        {
            return _organizationInfo;
        }
    }

    /// <summary>
    /// 员工 叶子
    /// </summary>
    public class Staff : Organization
    {

    }

}
