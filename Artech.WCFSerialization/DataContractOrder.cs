using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace Artech.WCFSerialization
{
    [DataContract(Name="Order",Namespace="http://www.xqlcrystal.com/Se")]
    [KnownType(typeof(DataContractProduct))]
    public class DataContractOrder
    {
        private Guid _orderID;

        [DataMember]
        public Guid OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        private DateTime _orderDate;

           [DataMember]
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
        private DataContractProduct _product;

           [DataMember]
        public DataContractProduct Product
        {
            get { return _product; }
            set { _product = value; }
        }
        private int _quantity;

           [DataMember]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public DataContractOrder()
        {
            this._orderID = new Guid();
            this._orderDate = DateTime.Now;
            this._quantity = int.MinValue;
            Console.WriteLine("The constructor of DataContractOrder has been invocated!");
        }

        public DataContractOrder(Guid id,DateTime orderdate,DataContractProduct product,int quantity)
        {
            this._orderID = id;
            this._orderDate = orderdate;
            this._product = product;
            this._quantity = quantity;

        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nDate:{1}\nProduct:\n\tID:{2}\n\tName:{3}\n\tProducing Area:{4}\n\tPrice:{5}\nQuantity:{6}",
               this._orderID, this._orderDate, this._product.ProductID, this._product.ProductName, this._product.ProducingArea, this._product.UnitPrice, this._quantity);
        }
    }
}
