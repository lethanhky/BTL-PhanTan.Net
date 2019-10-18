using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eEmployee
    {
        private int empID;
        private string name;
        private string address;
        private string phone;
        private string state;
        private string position;
        private int accId;

        public int EmpID { get => empID; set => empID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string State { get => state; set => state = value; }
        public int AccId { get => accId; set => accId = value; }
        public string Position { get => position; set => position = value; }

        public eEmployee()
        {
            this.empID = 0;
            this.name = "";
            this.address = "";
            this.phone = "";
            this.state = "";
            this.position = "";
            this.accId = 0;
        }
        public eEmployee(int empid, string name, string address,string phone,string state,string position,int accid)
        {
            this.empID = empid;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.state = state;
            this.position = position;
            this.accId = accid;
        }
    }
}
