using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

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

        [DataMember]
        public int TeleID { get => teleID; set => teleID = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public double Price { get => price; set => price = value; }
        [DataMember]
        public string Provider { get => provider; set => provider = value; }
        [DataMember]
        public string State { get => state; set => state = value; }
        [DataMember]
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
