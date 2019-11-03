using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using DAL;
using Entities;

namespace WcfQLDTDDD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        QLDTDDDataContext db;
        public Service1()
        {
            db = new QLDTDDDataContext();
        }


        //Account
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
        #endregion

        //Employee
        #region
        public List<eEmployee> getAllEmployee() // lay danh sach nhan vien
        {
            var lse = db.Employees.ToList();
            List<eEmployee> ls = new List<eEmployee>();
            foreach (Employee e in lse)
            {
                eEmployee em = new eEmployee();
                em.EmpID = (int)e.empID;
                em.Name = e.name;
                em.Address = e.address;
                em.Phone = e.phone;
                em.State = e.state;
                em.Position = e.position;
                em.AccId = (int)e.accID;
                ls.Add(em);
            }
            return ls;
        }
        public bool CheckIsExistEmployee(int empid) // kiem tra ton tai
        {
            Employee em = db.Employees.Where(x => x.empID == empid).FirstOrDefault();
            if (em != null) return true;
            else return false;
        }
        public void inSertEmployee(eEmployee newem) // them nhan vien
        {
            Employee em = new Employee();
            em.empID = newem.EmpID;
            em.name = newem.Name;
            em.address = newem.Address;
            em.phone = newem.Phone;
            em.state = newem.State;
            em.position = newem.Position;
            em.accID = newem.AccId;
            db.Employees.InsertOnSubmit(em);
            db.SubmitChanges();
        }
        public int editEmployee(eEmployee emold) // Chinh sua thong tin nhan vien
        {
            if (!CheckIsExistEmployee(emold.EmpID))
                return 0;
            IQueryable<Employee> em = db.Employees.Where(x => x.empID == emold.EmpID);
            em.First().name = emold.Name;
            em.First().address = emold.Address;
            em.First().phone = emold.Phone;
            em.First().state = emold.State;
            em.First().position = emold.Position;
            em.First().accID = (int)emold.AccId;
            db.SubmitChanges();
            return 1;
        }
        public List<eEmployee> searchEmployee(string input)//tim kiem nv 
        {
            var nvlist = db.Employees.Where(delegate (Employee c)
            {
                if (ConvertToUnSign(c.accID + c.name + c.address + c.phone + c.state + c.position + c.accID).IndexOf(input, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable();
            List<eEmployee> lnv = new List<eEmployee>();
            foreach (Employee nv in nvlist)
            {
                eEmployee t = new eEmployee();
                t.EmpID = (int)nv.empID;
                t.Name = nv.name;
                t.Address = nv.address;
                t.Phone = nv.phone;
                t.Position = nv.position;
                t.State = nv.state;
                t.AccId = (int)nv.accID;
                lnv.Add(t);
            }
            return lnv;
        }

        #endregion

        //Import Coupon
        #region

        #endregion

        //Import Coupon Detail
        #region

        #endregion

        //Order
        #region

        #endregion

        //Order Detail
        #region

        #endregion

        //Telephone
        #region
        public List<eTelephone> GetAllTelephone() // lay danh sach dt
        {
            var listTele = db.Telephones.ToList();
            List<eTelephone> lt = new List<eTelephone>();
            foreach (Telephone t in listTele)
            {
                eTelephone te = new eTelephone();
                te.TeleID = t.teleID;
                te.Name = t.name;
                te.ImpdetailID = (int)t.impdetaiID;
                te.Price = double.Parse(t.price.ToString());
                te.Provider = t.provider;
                te.State = t.state;
                lt.Add(te);
            }
            return lt;
        }
        public List<eTelephone> SearchTelephone(string input) //Tim kiem dien thoai
        {
            var listTele = db.Telephones.Where(delegate (Telephone c)
            {
                if (ConvertToUnSign(c.teleID + c.name + c.impdetaiID + c.price + c.provider + c.state).IndexOf(input, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable();

            List<eTelephone> lt = new List<eTelephone>();
            foreach (Telephone t in listTele)
            {
                eTelephone te = new eTelephone();
                te.TeleID = t.teleID;
                te.Name = t.name;
                te.ImpdetailID = (int)t.impdetaiID;
                te.Price = double.Parse(t.price.ToString());
                te.Provider = t.provider;
                te.State = t.state;
                lt.Add(te);
            }
            return lt;
        }
        public bool CheckIfExistTele(int teleID)// kiem tra ton tai
        {
            Telephone tele = db.Telephones.Where(x => x.teleID == teleID).FirstOrDefault();
            if (tele != null)
                return true;
            return false;
        }
        public int insertPhone(eTelephone tele) // them dien thoai moi
        {
            if (CheckIfExistTele(tele.TeleID))
                return 0;
            Telephone t = new Telephone();
            t.teleID = tele.TeleID;
            t.name = tele.Name;
            t.impdetaiID = tele.ImpdetailID;
            t.price = decimal.Parse(tele.Price.ToString());
            t.provider = tele.Provider;
            t.state = tele.State;

            db.Telephones.InsertOnSubmit(t);
            db.SubmitChanges();
            return 1;
        }
        public int updatePhone(eTelephone teleold) // Chinh sua thong tin nhan vien
        {
            if (!CheckIfExistTele(teleold.TeleID))
                return 0;
            IQueryable<Telephone> tele = db.Telephones.Where(x => x.teleID == teleold.TeleID);
            tele.First().name = teleold.Name;
            tele.First().price = (decimal)teleold.Price;
            tele.First().impdetaiID = teleold.ImpdetailID;
            tele.First().provider = teleold.Provider;
            tele.First().state = teleold.State;
            db.SubmitChanges();
            return 1;
        }
        #endregion

        //Dung chung
        #region
        public string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }
        #endregion
    }
}
