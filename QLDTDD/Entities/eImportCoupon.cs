using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eImportCoupon
    {
        private int impID;
        private DateTime impdetailDate;
        private int empID;
        private double total;

        public int ImpID { get => impID; set => impID = value; }
        public DateTime ImpdetailDate { get => impdetailDate; set => impdetailDate = value; }
        public int EmpID { get => empID; set => empID = value; }
        public double Total { get => total; set => total = value; }

        public eImportCoupon()
        {
            this.impID = 0;
            this.impdetailDate = DateTime.Now;
            this.empID = 0;
            this.total = 0;
        }
        public eImportCoupon(int impid, DateTime impdetaildate, int empid, double total)
        {
            this.impID = impid;
            this.impdetailDate = impdetaildate;
            this.empID = empid;
            this.total = total;
        }

    }
}
