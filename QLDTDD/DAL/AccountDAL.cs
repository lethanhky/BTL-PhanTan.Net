using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class AccountDAL
    {
        QLDTDDDataContext db;
        public AccountDAL()
        {
            db = new QLDTDDDataContext();
        }
        public bool CheckIsExist(int accid) // kiem tra ton tai
        {
            Account em = db.Accounts.Where(x => x.accID == accid).FirstOrDefault();
            if (em != null) return true;
            else return false;
        }
        public int InsertAccount(eAccount newacc) // them nhan vien
        {
            if (CheckIsExist((int)newacc.AccId)) return 0;
            else
            {
                Account ac = new Account();
                ac.accID = newacc.AccId;
                ac.username = newacc.UserName;
                ac.password = newacc.PassWord;
                db.Accounts.InsertOnSubmit(ac);
                db.SubmitChanges();
                return 1;
            }
        }
        public string GetAccidByUserName(string username)
        {
            Account ac = db.Accounts.Where(x => x.username == username).FirstOrDefault();
            return ac.accID.ToString().TrimEnd();
        }
    }
}
