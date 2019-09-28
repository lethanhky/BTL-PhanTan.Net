using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class eTelephone
    {
        private int teleID;
        private string name;
        private double price;
        private string provider;
        private string state;
        private int typeID;

        public int TeleID { get => teleID; set => teleID = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Provider { get => provider; set => provider = value; }
        public string State { get => state; set => state = value; }
        public int TypeID { get => typeID; set => typeID = value; }

        public eTelephone()
        {
            this.teleID = 0;
            this.name = "";
            this.price = 0;
            this.provider = "";
            this.state = "";
            this.typeID = 0;
        }
        public eTelephone(int teleid, string name, double price, string provider, string state, int typeid)
        {
            this.teleID = teleid;
            this.name = name;
            this.price = price;
            this.provider = provider;
            this.state = state;
            this.typeID = typeid;
        }
    }
}
