using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using DAL;
using Entities;

namespace WcfQLDTDD
{
    public class QLDTDDServices : IQLDTDDServices
    {
        QLDTDDDataContext db;
        public QLDTDDServices()
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
        public void DeleteAccount(int accid)
        {
            Account ac = db.Accounts.Where(x => x.accID == accid).FirstOrDefault();
            db.Accounts.DeleteOnSubmit(ac);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
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
        public List<eImportCoupon> GetAllImportCoupons()
        {
            var lsi = db.ImportCoupons.ToList();
            List<eImportCoupon> ls = new List<eImportCoupon>();
            foreach (ImportCoupon i in lsi)
            {
                eImportCoupon im = new eImportCoupon();
                im.ImpID = (int)i.impID;
                im.ImpdetailDate = (DateTime)i.impdetailDate;
                im.Total = (double)i.total;
                im.EmpID = (int)i.empID;
                ls.Add(im);
            }
            return ls;
        }
        public void InsertImportCoupon(eImportCoupon im)
        {
            ImportCoupon i = new ImportCoupon();
            i.impID = im.ImpID;
            i.impdetailDate = im.ImpdetailDate;
            i.total = (decimal)im.Total;
            i.empID = im.EmpID;
            db.ImportCoupons.InsertOnSubmit(i);
            db.SubmitChanges();
        }
        #endregion

        //Import Coupon Detail
        #region
        public List<eImportCouponDetail> GetAllImportCouponDetails()
        {
            var lsi = db.ImportCouponDetails.ToList();
            List<eImportCouponDetail> ls = new List<eImportCouponDetail>();
            foreach (ImportCouponDetail i in lsi)
            {
                eImportCouponDetail im = new eImportCouponDetail();
                im.ImpdetailID = (int)i.impdetaiID;
                im.Quantity = (int)i.quantity;
                im.Price = (double)i.price;
                im.Total = (double)i.total;
                im.ImpID = (int)i.impID;
                ls.Add(im);
            }
            return ls;
        }
        public void InsertImportCouponDetail(eImportCouponDetail imde)
        {
            ImportCouponDetail i = new ImportCouponDetail();
            i.impdetaiID = imde.ImpdetailID;
            i.quantity = imde.Quantity;
            i.price = (decimal)imde.Price;
            i.total = (decimal)imde.Total;
            i.impID = imde.ImpID;
            db.ImportCouponDetails.InsertOnSubmit(i);
            db.SubmitChanges();
        }
        #endregion

        //Order
        #region
        public List<eOrder> GetAllOrders()
        {
            var lsi = db.Orders.ToList();
            List<eOrder> ls = new List<eOrder>();
            foreach (Order i in lsi)
            {
                eOrder im = new eOrder();
                im.OrderID = (int)i.orderID;
                im.Total = (double)i.total;
                im.CusName = i.cusName;
                im.OrderDate = (DateTime)i.orderDate;
                im.State = i.state;
                im.EmpName = i.empName;
                im.EmpID = (int)i.empID;
                ls.Add(im);
            }
            return ls;
        }
        public void InsertOrder(eOrder o)
        {
            Order i = new Order();
            i.orderID = o.OrderID;
            i.total = (decimal)o.Total;
            i.cusName = o.CusName;
            i.orderDate = o.OrderDate;
            i.state = o.State;
            i.empName = o.EmpName;
            i.empID = o.EmpID;
            db.Orders.InsertOnSubmit(i);
            db.SubmitChanges();
        }
        #endregion

        //Order Detail
        #region

        public List<eOrderDetail> GetAllOrderDetails()
        {
            var lsi = db.OrderDetails.ToList();
            List<eOrderDetail> ls = new List<eOrderDetail>();
            foreach (OrderDetail i in lsi)
            {
                eOrderDetail im = new eOrderDetail();
                im.DetailID = (int)i.detailID;
                im.Unitprice = (double)i.unitprice;
                im.Amount = (double)i.amount;
                im.OrderID = (int)i.orderID;
                im.TeleID = (int)i.teleID;
                ls.Add(im);
            }
            return ls;
        }
        public void InsertOrderDetail(eOrderDetail od)
        {
            OrderDetail i = new OrderDetail();
            i.detailID = od.DetailID;
            i.unitprice = (decimal)od.Unitprice;
            i.amount = (decimal)od.Amount;
            i.orderID = od.OrderID;
            i.teleID = od.TeleID;
            db.OrderDetails.InsertOnSubmit(i);
            db.SubmitChanges();
        }
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
        public eTelephone GetETelephoneByName(string name)
        {
            Telephone tele = db.Telephones.Where(s => s.name == name).FirstOrDefault();
            if (tele != null)
            {
                eTelephone t = new eTelephone();
                t.TeleID = tele.teleID;
                t.Name = tele.name;
                t.Price = (double)tele.price;
                t.Provider = tele.provider;
                t.State = tele.state;
                t.ImpdetailID = (int)tele.impdetaiID;
                return t;
            }
            else
                return null;
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

        //Thống kê
        #region
        public int LayTheoSLB(int month, int year)
        {
            var odlist = (from s in db.Orders
                          where s.orderDate.Value.Month == month && s.orderDate.Value.Year == year
                          select s).ToList();
            List<eOrder> lOrder = new List<eOrder>();
            foreach (Order o in odlist)
            {
                eOrder t = new eOrder();
                t.OrderID = o.orderID;
                t.OrderDate = (DateTime)o.orderDate;
                t.State = o.state;
                t.Total = (Double)o.total;
                t.CusName = o.cusName;
                t.EmpName = o.empName;
                t.EmpID = (int)o.empID;
                lOrder.Add(t);
            }
            return lOrder.Count;

        }

        public Double ThongKeTheoTTB(int month, int year)
        {
            var odlist = (from s in db.Orders
                          where s.orderDate.Value.Month == month && s.orderDate.Value.Year == year
                          select s).ToList();
            List<eOrder> lOrder = new List<eOrder>();
            Double tt = 0;
            foreach (Order o in odlist)
            {
                tt += (Double)o.total;
            }
            return tt;

        }

        #endregion
    }
}
