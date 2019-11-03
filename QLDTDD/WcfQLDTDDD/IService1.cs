using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;

namespace WcfQLDTDDD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //Account
        #region
        [OperationContract]
        int InsertAccount(eAccount ac);
        [OperationContract]
        string getAccidbyUsername(string username);
        [OperationContract]
        bool CheckIsExistAccount(int accid)
        #endregion

        //Employee
        #region
        [OperationContract]
        List<eEmployee> getAllEmployee();
        [OperationContract]
        void inSertEmployee(eEmployee em);
        [OperationContract]
        int editEmployee(eEmployee em);
        [OperationContract]
        List<eEmployee> searchEmployee(string input);
        [OperationContract]
        bool CheckIsExistEmployee(int empid);
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
        [OperationContract]
        List<eTelephone> GetAllTelephone();
        [OperationContract]
        List<eTelephone> SearchTelephone(string input);
        [OperationContract]
        int insertPhone(eTelephone tele);
        [OperationContract]
        int updatePhone(eTelephone tele);
        [OperationContract]
        bool CheckIfExistTele(int teleID);
        #endregion

        //Dung chung
        [OperationContract]
        string ConvertToUnSign(string input);
    }

    
}
