using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eTelephone
    {
        private int teleID;
        private string name;
        private int impdetailID;
        private double price;
        private string provider;
        private string state;

        public int TeleID { get => teleID; set => teleID = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Provider { get => provider; set => provider = value; }
        public string State { get => state; set => state = value; }
        public int ImpdetailID { get => impdetailID; set => impdetailID = value; }

        public eTelephone()
        {
            this.teleID = 0;
            this.name = "";
            this.impdetailID = 0;
            this.price = 0;
            this.provider = "";
            this.state = "";
        }
        public eTelephone(int teleid, string name, int impdetailid, double price, string provider, string state)
        {
            this.teleID = teleid;
            this.name = name;
            this.impdetailID = impdetailid;
            this.price = price;
            this.provider = provider;
            this.state = state;
        }
    }
}
