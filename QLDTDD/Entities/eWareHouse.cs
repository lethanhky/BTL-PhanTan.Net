using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eWareHouse
    {
        private int wareId;
        private string wareName;
        private string address;
        private int typeID;

        public int WareId { get => wareId; set => wareId = value; }
        public string WareName { get => wareName; set => wareName = value; }
        public string Address { get => address; set => address = value; }
        public int TypeID { get => typeID; set => typeID = value; }

        public eWareHouse()
        {
            this.wareId = 0;
            this.wareName = "";
            this.address = "";
            this.typeID = 0;
        }
        public eWareHouse(int wareid, string warename,string address,int typeid)
        {
            this.wareId = wareid;
            this.wareName = warename;
            this.address = address;
            this.typeID = typeid;
        }
    }
}
