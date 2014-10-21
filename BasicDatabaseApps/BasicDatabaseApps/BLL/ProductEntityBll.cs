using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicDatabaseApps.DLL.DAO;
using BasicDatabaseApps.DLL.GETWAY;

namespace BasicDatabaseApps.BLL
{
    class ProductEntityBll
    {
        private ProductEntityGetway productEntityGetway;
        public ProductEntityBll()
        {
            productEntityGetway = new ProductEntityGetway();
        }
        public string Save(ProductInfo productInfo)
        {
            string meg = "";
            if (GetValidations(productInfo))
                return "  already insert ";
            else
            {
                if (productInfo.ProductCode.Length == 3)
                {
                    if (productInfo.ProductName.Length < 5 || productInfo.ProductName.Length < 11)
                    {
                        meg = productEntityGetway.Save(productInfo);
                    }
                    else
                    {
                        meg = "Product Name length must be btn five character to 10 character range";
                    }

                }
                else
                {
                    return "product code must be three character long not more not less";
                }
            }
            return meg;
        }
        public string GetTotalQuantity()
        {
          int sum = 0;
            List<int> quantityList=productEntityGetway.GetTotalQuantity();
            foreach (int i in quantityList)
            {
              sum +=i;
            }
            return sum.ToString();
        }

  

        public bool GetValidations(ProductInfo productInfo)
        {
            List<ProductInfo> productInfos = productEntityGetway.GetValidations();
            foreach (ProductInfo product in productInfos)
            {
                if (productInfo.ProductId ==product.ProductId||productInfo.ProductName==product.ProductName)
                {
                    return true;
                }
            }
            return false;
        }
     

        public List<ProductInfo> GetViewAll()
        {
            return productEntityGetway.GetViewAll();
        }
    }
}
