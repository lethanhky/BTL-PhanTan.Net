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
    public class eAccount
    {
        private int accId;
        private string userName;
        private string passWord;
        [DataMember]
        public int AccId { get => accId; set => accId = value; }
        [DataMember]
        public string UserName { get => userName; set => userName = value; }
        [DataMember]
        public string PassWord { get => passWord; set => passWord = value; }

        public eAccount()
        {
            this.accId = 0 ;
            this.userName = "";
            this.passWord = "";
        }
        public eAccount(int accid, string username, string password)
        {
            this.accId = accid;
            this.userName = username;
            this.passWord = password;
        }
    }
}
