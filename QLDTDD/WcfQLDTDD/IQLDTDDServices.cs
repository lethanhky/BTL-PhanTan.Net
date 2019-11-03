using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;

namespace WcfQLDTDD
{
    [ServiceContract]
    public interface IQLDTDDServices
    {
        //Account
        #region
        [OperationContract]
        int InsertAccount(eAccount ac);
        [OperationContract]
        string getAccidbyUsername(string username);
        [OperationContract]
        bool CheckIsExistAccount(int accid);
        [OperationContract]
        void DeleteAccount(int accid);
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
        [OperationContract]
        List<eImportCoupon> GetAllImportCoupons();
        [OperationContract]
        void InsertImportCoupon(eImportCoupon im);
        #endregion

        //Import Coupon Detail
        #region
        [OperationContract]
        List<eImportCouponDetail> GetAllImportCouponDetails();
        [OperationContract]
        void InsertImportCouponDetail(eImportCouponDetail imde);
        #endregion

        //Order
        #region
        [OperationContract]
        List<eOrder> GetAllOrders();
        [OperationContract]
        void InsertOrder(eOrder o);
        #endregion

        //Order Detail
        #region
        [OperationContract]
        List<eOrderDetail> GetAllOrderDetails();
        [OperationContract]
        void InsertOrderDetail(eOrderDetail od);
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
        #region
        [OperationContract]
        string ConvertToUnSign(string input);
        #endregion
    }

}
