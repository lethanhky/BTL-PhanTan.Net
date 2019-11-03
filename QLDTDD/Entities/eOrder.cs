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
    public class eOrder
    {
        private int orderID;
        private double total;
        private string cusName;
        private DateTime orderDate;
        private string state;
        private string empName;
        private int empID;

        [DataMember]
        public int OrderID { get => orderID; set => orderID = value; }
        [DataMember]
        public double Total { get => total; set => total = value; }
        [DataMember]
        public string CusName { get => cusName; set => cusName = value; }
        [DataMember]
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        [DataMember]
        public string State { get => state; set => state = value; }
        [DataMember]
        public string EmpName { get => empName; set => empName = value; }
        [DataMember]
        public int EmpID { get => empID; set => empID = value; }

        public eOrder()
        {
            this.orderID = 0;
            this.total = 0;
            this.cusName = "";
            this.orderDate = DateTime.Now;
            this.state = "";
            this.empName = "";
            this.empID = 0;
        }
        public eOrder(int orderid, float total, string cusname, DateTime orderdate, string state,string empname , int empid)
        {
            this.orderID = orderid;
            this.total = total;
            this.cusName = cusname;
            this.orderDate = orderdate;
            this.state = state;
            this.empName = empname;
            this.empID = empid;
        }
    }
}
