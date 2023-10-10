using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 指挥者（采购经理）
    /// </summary>
    public class Director
    {
        public Computer Construct(IBuilder builder)
        {
            return builder.BuildComputer();
        }
    }

    /// <summary>
    /// 惠普电脑组装商
    /// </summary>
    public class HpBulider : IBuilder
    {
        Computer hp = new Computer() { Band = "惠普" };

        public void BuildMainFramePart()
        {
            hp.AssemblePart("主机");
        }

        public void BuildScreenPart()
        {
            hp.AssemblePart("显示器");
        }

        public void BuildInputPart()
        {
            hp.AssemblePart("键鼠");
        }

        /// <summary>
        /// 决定具体的组装步骤
        /// </summary>
        /// <returns></returns>
        public Computer BuildComputer()
        {
            BuildMainFramePart();
            BuildScreenPart();
            BuildInputPart();
            return hp;
        }
    }

    /// <summary>
    /// 戴尔电脑组装商
    /// </summary>
    public class DellBulider : IBuilder
    {
        Computer dell = new Computer() { Band = "戴尔" };

        public void BuildMainFramePart()
        {
            dell.AssemblePart("主机");
        }

        public void BuildScreenPart()
        {
            dell.AssemblePart("显示器");
        }

        public void BuildInputPart()
        {
            dell.AssemblePart("键鼠");
        }

        public Computer BuildComputer()
        {
            BuildInputPart();
            BuildMainFramePart();
            BuildScreenPart();
            return dell;
        }
    }

    /// <summary>
    /// 产品类
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 品牌
        /// </summary>
        public string Band { get; set; }

        /// <summary>
        /// 电脑组件列表
        /// </summary>
        private List<string> assemblyParts = new List<string>();

        /// <summary>
        /// 组装部件
        /// </summary>
        /// <param name="partName">部件名称</param>
        public void AssemblePart(string partName)
        {
            assemblyParts.Add(partName);
        }

        public void ShowSteps()
        {
            Console.WriteLine($"开始组装『{Band}』电脑:");
            foreach (var part in assemblyParts)
            {
                Console.WriteLine($"组装『{part}』;");
            }

            Console.WriteLine($"组装『{Band}』电脑完毕！");
        }
    }



}
