using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    class TelephoneDAL
    {
        QLDTDDDataContext db;
        public TelephoneDAL()
        {
            db = new QLDTDDDataContext();
        }
        public List<eTelephone> getAllTelephone() // lay danh sach dt
        {
            var listTele = db.Telephones.ToList();
            List<eTelephone> lt = new List<eTelephone>();
            foreach(Telephone t in listTele)
            {
                eTelephone te = new eTelephone();
                te.TeleID = t.teleID;
                te.Name = t.name;
                te.Price = double.Parse(t.price.ToString());
                te.Provider = t.provider;
                te.State = t.state;
                te.TypeID = int.Parse(t.typeID.ToString());
                lt.Add(te);
            }
            return lt;
        }

        //public List<eTelephone> getTelephoneByTypeID() //lay danh sach dt theo ma loai
        //{

        //}
    }
}
