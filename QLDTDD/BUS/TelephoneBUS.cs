using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BUS
{
    public class TelephoneBUS
    {
        TelephoneDAL teleDAL;
        public TelephoneBUS()
        {
            teleDAL = new TelephoneDAL();
        }
        public List<eTelephone> GetAllTelephone()
        {
            return teleDAL.getAllTelephone();
        }
       
        public List<eTelephone> SearchTelephone(string input)
        {
            return teleDAL.SearchTelephone(input);
        }
        public int insertPhone(eTelephone tele)
        {
            return teleDAL.insertTelephone(tele);
        }
        public int updatePhone(eTelephone tele)
        {
            return teleDAL.EditTelephone(tele);
        }
    }
}
