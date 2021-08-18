using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        string _productName;
        public string ProductName
        {
            get 
            {
                return StringHandler.InsertSpaces(_productName);
            }
            set
            {
                _productName = value;

            }
        }

    }
}
