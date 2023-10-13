namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*  责任链模式   行为型模式 
              应用场景： 流程业务，各司其职，就可以考虑『责任链模式』
                优点:责任链模式非常显著的优点是将请求和处理分开。请求者可以不用知道是谁处理的，处理者可以不用知道请求的全貌，两者解耦，提高系统的灵活性。
                缺点：一是性能问题，每个请求都是从链头遍历到链尾，特别是在链比较长的时候，性能是一个非常大的问题。
                     二是调试不很方便，特别是链条比较长，环节比较多的时候，由于采用了类似递归的方式，调试的时候逻辑可能比较复杂。

            速记：中间件管道就是一种责任链模式 可以灵活处理 
             */


            PurchaseBill bill = new PurchaseBill()
            {
                BilNo = "BO001",
                MaterialName = "Computer",
                Qty = 50,
                Price = 5000,
                BillMaker = new Purchaser("采购员")
             
            };

            Console.WriteLine($"创建采购申请单：{bill.BilNo};申请购买{bill.Qty}台{bill.MaterialName}");

            bill.BillMaker.HandleBill(bill);

            Console.ReadLine();
        }
    }
}