using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _4Practice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        List<Order> GetOrders(int id);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id
        {
            get;
            set;
        }

        [DataMember]
        public String Name
        {
            get;
            set;
        }

        [DataMember]
        public String Surname
        {
            get;
            set;
        }

        [DataMember]
        public int YearOfBirth
        {
            get;
            set;
        }
    }

    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id
        {
            get;
            set;
        }

        [DataMember]
        public String Title
        {
            get;
            set;
        }

        [DataMember]
        public int IdCust
        {
            get;
            set;
        }

        [DataMember]
        public int Price
        {
            get;
            set;
        }

        [DataMember]
        public int Quantity
        {
            get;
            set;
        }
    }
}
