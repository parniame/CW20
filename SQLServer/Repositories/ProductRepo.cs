using DataAccess.SQLServer.Entities;
using Microsoft.EntityFrameworkCore;
using SQLServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer.Repositories
{
    internal class ProductRepo : IProductRepo
    {
        private readonly TestContext _dbContext;
        public ProductRepo(TestContext dbContext)
        {
            _dbContext = dbContext;
            
        }
        public List<Product> GetProductsByCustomerID(int id)
        {
           var res =  _dbContext.Orders.Where(x => x.CustomerId == id).SelectMany(x => x.OrderProducts).Select(x => x.Product);
            return res.ToList();

        }
        public List<Product> GetProductsWithDiscountsByShopId(int shopID)
        {
            var res = _dbContext.ShopProducts.Where(x => x.ShopId == shopID).Select(x => x.Product).Include(x => x.Discounts);
            return res.ToList();
        }
        public int GetCountOfSalesByCustomerID(int id)
        {
            var res = _dbContext.Orders.Where(x => x.CustomerId == id).SelectMany(x => x.OrderProducts).Sum(x => x.Quantity);
            return res;
        }

    }
}
