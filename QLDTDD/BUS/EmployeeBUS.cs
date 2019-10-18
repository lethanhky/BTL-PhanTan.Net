using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BUS
{
    public class EmployeeBUS
    {
        EmployeeDAL emDAL;
        public EmployeeBUS()
        {
            emDAL = new EmployeeDAL();
        }
        public List<eEmployee> getAllEmployee()
        {
            return emDAL.getAllEmployee();
        }
        public void inSertEmployee(eEmployee em)
        {
            emDAL.InsertEmployee(em);
        }
        public int editEmployee(eEmployee em)
        {
            return emDAL.EditEmployee(em);
        }
        public List<eEmployee> searchItem(string input)
        {
            return emDAL.SearchEmployee(input);
        }
    }
}
