using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class EmployeeDAL
    {
        QLDTDDDataContext db;
        public EmployeeDAL()
        {
            db = new QLDTDDDataContext();
        }
        public List<eEmployee> getAllEmployee() // lay danh sach nhan vien
        {
            var lse = db.Employees.ToList();
            List<eEmployee> ls = new List<eEmployee>();
            foreach(Employee e in lse)
            {
                eEmployee em = new eEmployee();
                em.EmpID = (int)e.empID;
                em.Name = e.name;
                e.address = e.address;
                e.phone = e.phone;
                e.state = e.state;
                em.AccId = (int)e.accID;
                ls.Add(em);
            }
            return ls;
        }
        public bool CheckIsExist(int empid) // kiem tra ton tai
        {
            Employee em = db.Employees.Where(x => x.empID == empid).FirstOrDefault();
            if (em != null) return true;
            else return false;
        }
        public int InsertEmployee(Employee newem) // them nhan vien
        {
            if (CheckIsExist((int)newem.empID)) return 0;
            else
            {
                Employee em = new Employee();
                em.empID = newem.empID;
                em.name = newem.name;
                em.address = newem.address;
                em.phone = newem.phone;
                em.state = newem.state;
                em.accID = newem.accID;
                db.Employees.InsertOnSubmit(em);
                db.SubmitChanges();
                return 1;
            }
        }
        public void EditEmployee(Employee emold) // Chinh sua thong tin nhan vien
        {
            IQueryable<Employee> em = db.Employees.Where(x => x.empID == emold.empID);
            em.First().name = emold.name;
            em.First().address = emold.address;
            em.First().phone = emold.phone;
            em.First().state = emold.state;
            em.First().accID = (int)emold.accID;
            db.SubmitChanges();
        }
        public List<eEmployee> SearchEmployee(string input)//tim kiem nv 
        {
            var nvlist = db.Employees.Where(delegate (Employee c)
            {
                if (ConvertToUnSign(c.accID + c.name + c.address + c.phone + c.state + c.accID).IndexOf(input, StringComparison.CurrentCultureIgnoreCase) >= 0)
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
                t.State = nv.state;
                t.AccId = (int)nv.accID;
                lnv.Add(t);
            }
            return lnv;
        }
        private string ConvertToUnSign(string input)
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
    }
}
