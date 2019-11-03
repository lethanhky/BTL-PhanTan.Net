using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using DAL;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        QLDTDDDataContext db;
        public QLDTDDServices()
        {
            db = new QLDTDDDataContext();
        }
        #region
        public bool CheckIsExistAccount(int accid) // kiem tra ton tai
        {
            Account em = db.Accounts.Where(x => x.accID == accid).FirstOrDefault();
            if (em != null) return true;
            else return false;
        }
        public int InsertAccount(eAccount newacc) // them nhan vien
        {
            if (CheckIsExistAccount((int)newacc.AccId)) return 0;
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
        public string getAccidbyUsername(string username)
        {
            Account ac = db.Accounts.Where(x => x.username == username).FirstOrDefault();
            return ac.accID.ToString().TrimEnd();
        }
    }
}
