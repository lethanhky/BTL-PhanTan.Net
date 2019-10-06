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
        public List<eTelephone> GetTelephoneByID(int id)
        {
            return teleDAL.getTelephoneByTypeID(id);
        }
        public List<eTelephone> SearchTelephone(string input)
        {
            return teleDAL.SearchTelephone(input);
        }
        public int insertPhone(eTelephone tele)
        {
            return teleDAL.insertTelephone(tele);
        }
        public void updatePhone(eTelephone tele)
        {
            teleDAL.EditTelephone(tele);
        }
    }
}
