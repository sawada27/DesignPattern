using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 单据状态
    /// </summary>
    public enum BillStatus
    {
        //打开
        Open,
        //保存
        Saved,
        //已提交
        Submitted,
        //已审核
        Audited
    }

    /// <summary>
    /// 单据
    /// </summary>
    public abstract class Bill
    {

        /// <summary>
        /// 单据名
        /// </summary>
        public string BillName { get; set; } = string.Empty;    

        /// <summary>
        /// 单据号
        /// </summary>
        public string BilNo { get; set; }


        /// <summary>
        /// 单据状态
        /// </summary>
        public BillStatus Status { get; set; }

        /// <summary>
        /// 物料名
        /// </summary>
        public string MaterialName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// 单位价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal Amount
        {
            get
            {
                return Qty * Price;
            }
        }

        
        /// <summary>
        /// 处理者
        /// </summary>
        public Handler BillMaker { get; set; }
    }

    /// <summary>
    /// 采购单
    /// </summary>
    public class PurchaseBill : Bill
    {
        public PurchaseBill()
        {
            base.Status = BillStatus.Open;
            base.BillName = "采购申请单";
        }
    }

}
