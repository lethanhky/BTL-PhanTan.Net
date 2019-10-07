using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eImportCouponDetail
    {
        private int impdetailID;
        private int quantity;
        private double price;
        private double total;
        private int impID;

        public int ImpdetailID { get => impdetailID; set => impdetailID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public double Total { get => total; set => total = value; }
        public int ImpID { get => impID; set => impID = value; }

        public eImportCouponDetail()
        {
            this.impdetailID = 0;
            this.quantity = 0;
            this.price = 0;
            this.total = 0;
            this.impID = 0;
        }
        public eImportCouponDetail(int impdetailid, int quantity, double price, double total,int impid)
        {
            this.impdetailID = impdetailid;
            this.quantity = quantity;
            this.price = price;
            this.total = total;
            this.impID = impid;
        }
    }
}
