using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 建造者（模拟装机过程）
    /// </summary>
    public  interface IBuilder
    {
        /// <summary>
        /// 组装主机
        /// </summary>
         void BuildMainFramePart();

        /// <summary>
        /// 组装显示器
        /// </summary>
         void BuildScreenPart();

        /// <summary>
        /// 组装输入设备（键鼠）
        /// </summary>
         void BuildInputPart();

        /// <summary>
        /// 获取组装电脑
        /// 由具体的组装类决定组装顺序
        /// </summary>
        /// <returns></returns>
         Computer BuildComputer();
    }


}
