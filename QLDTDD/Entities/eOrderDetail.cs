using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Entities
{
    [DataContract]
    public class eOrderDetail
    {
        private int detailID;
        private int quantity;
        private double unitprice;
        private double amount;
        private int orderID;
        private int teleID;

        [DataMember]
        public int DetailID { get => detailID; set => detailID = value; }
        [DataMember]
        public int Quantity { get => quantity; set => quantity = value; }
        [DataMember]
        public double Unitprice { get => unitprice; set => unitprice = value; }
        [DataMember]
        public double Amount { get => amount; set => amount = value; }
        [DataMember]
        public int OrderID { get => orderID; set => orderID = value; }
        [DataMember]
        public int TeleID { get => teleID; set => teleID = value; }

        public eOrderDetail()
        {
            this.detailID = 0;
            this.quantity = 0;
            this.unitprice = 0;
            this.amount = 0;
            this.orderID = 0;
            this.teleID = 0;
        }
        public eOrderDetail(int detailid, int quantity, double unitprice, double amount, int orderid, int teleid)
        {
            this.detailID = detailid;
            this.quantity = quantity;
            this.unitprice = unitprice;
            this.amount = amount;
            this.orderID = orderid;
            this.teleID = teleid;
        }
    }
}
