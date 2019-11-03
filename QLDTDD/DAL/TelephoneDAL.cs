using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class TelephoneDAL
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
                te.ImpdetailID = (int)t.impdetaiID;
                te.Price = double.Parse(t.price.ToString());
                te.Provider = t.provider;
                te.State = t.state;
                lt.Add(te);
            }
            return lt;
        }
        #region
        //public List<eTelephone> getTelephoneByTypeID(int typeid) //lay danh sach dt theo ma loai
        //{
        //    var listTele = db.Telephones.Where(x => x.typeID == typeid).ToList();
        //    List<eTelephone> lt = new List<eTelephone>();
        //    foreach(Telephone t in listTele)
        //    {
        //        eTelephone te = new eTelephone();
        //        te.TeleID = t.teleID;
        //        te.Name = t.name;
        //        te.Price = double.Parse(t.price.ToString());
        //        te.Provider = t.provider;
        //        te.State = t.state;
        //        te.TypeID = int.Parse(t.typeID.ToString());
        //        lt.Add(te);
        //    }
        //    return lt;
        //}
        #endregion
        private string ConvertToUnSign(string input) // convert tu khoa tim kiem
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
        public int insertTelephone(eTelephone tele) // them dien thoai moi
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
        public int EditTelephone(eTelephone teleold) // Chinh sua thong tin nhan vien
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
    }
}
