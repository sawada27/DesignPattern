namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 适配器模式   结构型模式
            使用场景：
            将一个接口转换成另一个接口，使不兼容的类可以一起工作。  
             当你希望使用某个类， 但是其接口与其他代码不兼容时， 可以使用适配器类。
            适配器模式允许你创建一个中间层类， 其可作为代码与遗留类、 第三方类或提供怪异接口的类之间的转换器。

            速记：在不修改已有代码的情况下使现有代码适配新的接口。保留原有功能
            优点：解耦客户端和现有接口，复用现有类。
            缺点：增加了类的复杂性。

            */

            //在未定义充电标准之前，各个厂家充电线的实现各不相同，但都可以为自家品牌设备充电
            USBLine usbLine = new USBLine();
            usbLine.Charge();

         
            //随着电器设备越来越多，各家的充电设备不能通用，造成很多不便，为了共用，厂家联合推出标准充电接口。

            //USB-Micro实现标准接口。
            IChargingLine microLine = new USBMicroLine();
            microLine.Charging();


            Console.WriteLine();

            //现在手里有一个未实现充电标准的充电线，通过适配器，为Type-C设备充电
            Console.WriteLine("对象适配器模式： 构造注入或者New一个 推荐使用 ");
            IChargingLine typeCLineAdapter = new USBTypecLineAdapter(usbLine);
            typeCLineAdapter.Charging();

           
            Console.WriteLine();

            //现在手里有一个未实现充电标准的充电线，通过适配器，为苹果设备充电 
            Console.WriteLine("类适配器模式： 继承 ");
            IChargingLine lightingLineAdapter = new USBlightingLineAdapter();
            lightingLineAdapter.Charging();

            Console.ReadLine();
        }
    }
}