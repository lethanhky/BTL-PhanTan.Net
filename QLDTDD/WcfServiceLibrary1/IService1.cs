using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int InsertAccount(eAccount ac);
        [OperationContract]
        string getAccidbyUsername(string username);
        [OperationContract]
        bool CheckIsExistAccount(int accid);
    }
    
}
