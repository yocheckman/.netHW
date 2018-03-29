using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace yoyoyo.Models
{
    public class Orders
    {
        [DisplayName("訂單編號")]
        public int OrderID { get; set; }
        [DisplayName("客戶編號")]
        public int CustomerID { get; set; }
        [DisplayName("員工編號")]
        public int EmployeeID { get; set; }

        [DisplayName("訂單日期")]
        public DateTime OrderDate { get; set; }
        [DisplayName("需要日期")]
        public DateTime RequiredDate { get; set; }
        [DisplayName("出貨日期")]
        public DateTime ShippedDate { get; set; }

        [DisplayName("出貨編號")]
        public int ShipperID { get; set; }
        public Decimal Freight { get; set; }
        [DisplayName("出貨地址")]
        public Char[] ShipAddress { get; set; }
        [DisplayName("出貨城市")]
        public Char[] ShipCity { get; set; }
        [DisplayName("出貨地區")]
        public Char[] ShipRegion { get; set; }
        [DisplayName("郵遞區號")]
        public Char[] ShipPostalCode { get; set; }
        [DisplayName("出貨國家")]
        public Char[] ShipCountry { get; set; }

        public List<Orders> GetOrder()
        {
            var Order = new List<Orders>()
            {
                new Orders
                {
                    OrderID=1,
                    CustomerID=1,
                    EmployeeID=1,
                    OrderDate=2018-01-01,
                },
                new Orders
                {

                }
            };
            return Order;
        }

    }
}