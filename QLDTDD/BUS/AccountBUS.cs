using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BUS
{
    public class AccountBUS
    {
        AccountDAL accDAL;
        public AccountBUS()
        {
            accDAL = new AccountDAL();
        }
        public int InsertAccount(eAccount ac)
        {
            return accDAL.InsertAccount(ac);
        }
        public string getAccidbyUsername(string username)
        {
            string s = accDAL.GetAccidByUserName(username);
            return s;
        }
    }
}
