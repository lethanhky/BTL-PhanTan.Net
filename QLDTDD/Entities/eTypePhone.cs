using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class eTypePhone
    {
        private int typeID;
        private string typeName;
        private int quantity;

        public int TypeID { get => typeID; set => typeID = value; }
        public string TypeName { get => typeName; set => typeName = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public eTypePhone()
        {
            this.typeID = 0;
            this.typeName = "";
            this.quantity = 0;
        }
        public eTypePhone(int typeid, string typename, int quantity)
        {
            this.typeID = typeid;
            this.typeName = typename;
            this.quantity = quantity;
        }
    }
}
