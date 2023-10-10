using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
 

    /// <summary>
    /// 默认实现 USB数据线（支持USB-Micro端口的设备）
    /// </summary>
    public class USBMicroLine : IChargingLine
    {
        public void Charging()
        {
            Console.WriteLine("为支持USB-Micro端口的设备充电！");
        }
    }

    /// <summary>
    /// 原装数据线 原有方法
    /// 未定义充电标准的充电方法
    /// </summary>
    public class USBLine
    {
        public void Charge()
        {
            Console.WriteLine("为设备充电！");
        }
    }

    #region 类适配 

    /// <summary>
    /// USB-Lighting充电线适配器  破坏封装性 不推荐
    /// </summary>
    public class USBlightingLineAdapter : USBLine, IChargingLine
    {
        public void Charging()
        {
            Console.WriteLine("对USB-Lighting端口的数据线进行适配！");
            base.Charge();
        }
    }

    #endregion

    #region 对象适配

    /// <summary>
    /// Type-C充电线适配器
    /// </summary>
    public class USBTypecLineAdapter : IChargingLine
    {
        private readonly USBLine _usbLine;

        public USBTypecLineAdapter()
        {
            _usbLine = new USBLine();
        }

        public USBTypecLineAdapter(USBLine usbLine)
        {
            _usbLine = usbLine;
        }

        public void Charging()
        {
            Console.WriteLine("对USB-TypeC端口的数据线进行适配！");
            _usbLine.Charge();
        }
    }

    #endregion
}
