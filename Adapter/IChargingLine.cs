using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 充电线  适配成目标角色
    /// </summary>
    public interface IChargingLine
    {
        /// <summary>
        /// 充电方法
        /// </summary>
        void Charging();
    }
}
