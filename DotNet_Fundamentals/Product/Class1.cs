using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class clsProduct
    {
        public int getTotalCost(int intQty, int intPerProduct)
        {
            return intQty * intPerProduct;
        }
        public int getTotalCost(int intQty, int intPerProduct, int intDiscount)
        {
            return (getTotalCost(intQty, intPerProduct) - intDiscount);
        }
        public virtual string getTotalCost(int intQty, int intPerProduct, string strCurrency)
        {
            return "The total cost is : " + getTotalCost(intQty, intPerProduct).ToString() + " " + strCurrency;
        }
    }
    public class clsProductWithDiscount : clsProduct
    {
        public override string getTotalCost(int intQty, int intPerProduct, string strCurrency)
        {
            return "The total cost with discount of 10%  : "
                + getTotalCost(intQty, intPerProduct, 10).ToString() +
                " " + strCurrency;
        }
        public int getTotalCost(int intQty, int intPerProduct, int intDiscount)
        {
            return (getTotalCost(intQty, intPerProduct) - intDiscount);
        }
    }
    public class clsProductEncapsulation
    {
        private int _intQty;
        private int _intPerProduct;
        public int Qty
        {
            set
            {
                if (IsQuantityGreater(value))
                {
                    throw new Exception("Qty exceeds the limit");
                }

                _intQty = value;
            }
            get
            {
                return _intQty;
            }
        }
        private bool IsQuantityGreater(int intQty)
        {
            if (intQty > 100)
            {
                return true;
            }
            return false;
        }
        public int PerProductCost
        {
            set
            {
                if (isProductCostZero(value))
                {
                    throw new Exception("Product cost is zero");
                }
                _intPerProduct = value;
            }
            get
            {
                return _intPerProduct;
            }
        }
        private bool isProductCostZero(int intProductCost)
        {
            if (intProductCost == 0)
            {
                return true;
            }
            return false;
        }
        public int TotalCost
        {
            get
            {
                return _intQty * _intPerProduct;
            }
        }
    }
}
