using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 单据处理角色
    /// </summary>
    public abstract class Handler
    {
        /// <summary>
        /// 单据处理者姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 单据处理者具有的权限
        /// </summary>
        public List<string> Permissions { get; set; }

        /// <summary>
        /// 检查权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public bool CheckPermission(string permission)
        {
            return Permissions.Contains(permission);
        }

        //声明下一个处理者
        protected Handler Successor { get; set; }


        /// <summary>
        /// 处理单据
        /// </summary>
        /// <param name="bill"></param>
        public void HandleBill(Bill bill)
        {
            //单据处理从保存开始
            if (CheckPermission("SAVE") && bill.Status == BillStatus.Open)
            {
                this.DoBillOperation(bill);
            }
            else
            {
                this.Successor.DoBillOperation(bill);
            }
        }

        public abstract void DoBillOperation(Bill bill);

    }

    public class Purchaser : Handler
    {
        private List<string> permissions = new List<string>() { "SAVE" };

        public Purchaser(string username)
        {
            base.UserName = username;
            base.Permissions = permissions;
            base.Successor = new Manager("经理");//在构造函数中指定下一个处理者
        }

        public override void DoBillOperation(Bill bill)
        {
            if (CheckPermission("SAVE") && bill.Status == BillStatus.Open)
            {
                bill.Status = BillStatus.Saved;
                Console.WriteLine($"{this.UserName}：{bill.BilNo}已经保存！");
            }

            if (CheckPermission("SUBMIT") && bill.Status == BillStatus.Saved)
            {
                bill.Status = BillStatus.Submitted;
                Console.WriteLine($"{this.UserName}：{bill.BilNo}已经提交！");
            }

            if (CheckPermission("AUDIT") && bill.Status == BillStatus.Submitted)
            {
                if (bill.Amount <= 5000)
                {
                    bill.Status = BillStatus.Submitted;
                    Console.WriteLine($"{this.UserName}：{bill.BilNo}已经审核！");
                }
                else
                {
                    this.Successor.DoBillOperation(bill);
                }

            }
            else
            {
                this.Successor.DoBillOperation(bill);
            }
        }
    }

    public class Manager : Handler
    {
        private List<string> permissions = new List<string>() { "SAVE", "SUBMIT", "AUDIT" };

        public Manager(string userName)
        {
            base.UserName = userName;
            base.Permissions = permissions;
            base.Successor = new CEO("CEO首席执行官");
        }

        public override void DoBillOperation(Bill bill)
        {
            if (CheckPermission("SAVE") && bill.Status == BillStatus.Open)
            {
                bill.Status = BillStatus.Saved;
                Console.WriteLine(string.Format("{0}：{1}已经保存！", this.UserName, bill.BilNo));
            }

            if (CheckPermission("SUBMIT") && bill.Status == BillStatus.Saved)
            {
                bill.Status = BillStatus.Submitted;
                Console.WriteLine(string.Format("{0}：{1}已经提交！", this.UserName, bill.BilNo));
            }

            if (CheckPermission("AUDIT") && bill.Status == BillStatus.Submitted)
            {
                if (bill.Amount <= 20000)
                {
                    bill.Status = BillStatus.Submitted;
                    Console.WriteLine(string.Format("{0}：{1}已经审核！", this.UserName, bill.BilNo));
                }
                else
                {
                    this.Successor.DoBillOperation(bill);
                }

            }
            else
            {
                this.Successor.DoBillOperation(bill);
            }
        }
    }

    public class CEO : Handler
    {
        private List<string> permissions = new List<string>() { "SAVE", "SUBMIT", "AUDIT" };

        public CEO(string userName)
        {
            base.UserName = userName;
            base.Permissions = permissions;
        }

        public override void DoBillOperation(Bill bill)
        {
            if (CheckPermission("SAVE") && bill.Status == BillStatus.Open)
            {
                bill.Status = BillStatus.Saved;
                Console.WriteLine(string.Format("{0}：{1}已经保存！", this.UserName, bill.BilNo));
            }

            if (CheckPermission("SUBMIT") && bill.Status == BillStatus.Saved)
            {
                bill.Status = BillStatus.Submitted;
                Console.WriteLine(string.Format("{0}：{1}已经提交！", this.UserName, bill.BilNo));
            }

            if (CheckPermission("AUDIT") && bill.Status == BillStatus.Submitted)
            {
                bill.Status = BillStatus.Submitted;
                Console.WriteLine(string.Format("{0}：{1}已经审核！", this.UserName, bill.BilNo));
            }
        }
    }
}
