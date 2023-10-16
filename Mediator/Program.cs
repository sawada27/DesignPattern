namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 中介者模式    行为型模式
 使用场景： 当一个系统中对象之间的通信复杂并且导致高度耦合时，使用中介者模式可以降低耦合度。
            当一个系统中的对象交互频繁，但您希望避免对象直接通信时，中介者模式非常有用。
            当需要一个可扩展的系统，可以轻松添加新的对象并修改通信规则时，中介者模式是一个不错的选择。
            在图形用户界面应用程序中，中介者模式通常用于处理用户界面组件之间的交互。

     优点：
            减少耦合：中介者模式减少了对象之间的直接通信，从而降低了耦合度。对象不再需要了解彼此的详细信息，只需与中介者进行交互。
            集中控制：中介者模式将系统的通信集中在一个对象上，使得系统更容易管理和维护。
            增加可扩展性：由于通信逻辑由中介者处理，因此添加新的对象或更改通信规则变得更加容易。

     缺点：复杂性增加：中介者本身可能会变得复杂，因为它需要处理多个对象之间的通信。这可能导致中介者本身的复杂性增加。
            性能开销：由于所有通信都经过中介者，可能会引入性能开销，特别是在大型系统中。

     速记: 对象之间的交互由一个整体中介者来做
*/



            AbstractMediator mediator = new Mediator();

            //声明参与的角色
            HomeBuyer buyer = new HomeBuyer(mediator);
            Builder build = new Builder(mediator);
            ControlCenter center = new ControlCenter(mediator);

            //将需要的角色注入到中介
            mediator.HouseBuilder = build;
            mediator.HomeBuyer = buyer;
            mediator.ControlCenter = center;

            int initRequirement = mediator.GetBuyRequirement();
            int initHousenum = mediator.GetCurrentHouseNumber();

            Console.WriteLine($"目前购房需求为：{initRequirement}套;现有房源：{initHousenum}套。");

            //买房300套
            buyer.BuyHouse(300);

            build.SaleHouse(300);

            //国家住建局，考察市场
            center.Limit();

            //再买房1000套
            buyer.BuyHouse(1000);

            Console.ReadLine();
        }
    }
}