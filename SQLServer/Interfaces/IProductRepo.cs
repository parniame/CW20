using DataAccess.SQLServer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer.Interfaces
{
    public interface IProductRepo
    {
        List<Product> GetProductsByCustomerID(int id);
        List<Product> GetProductsWithDiscountsByShopId(int shopID);
        int GetCountOfSalesByCustomerID(int id);
    }
}
