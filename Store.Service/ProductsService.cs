using Microsoft.EntityFrameworkCore;
using Store.Model;

namespace Store.Service
{
	public class ProductService : IProductService
	{
		private StoreDbContext _dbContext;
		public ProductService(StoreDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void AddProduct(Products products)
		{
			_dbContext.Add(products);
			_dbContext.SaveChangesAsync();
		}

		public void DeleteProduct(int id)
		{
			var entity = GetProductById(id);
			_dbContext.Set<Products>().Remove(entity);
			_dbContext.SaveChanges();
		}

		private Products GetProductById(int id)
		{
			return _dbContext.Set<Products>().Find(id);
		}

		public IEnumerable<Products> GetAllProducts()
		{
			return _dbContext.Products.ToList();
		}
	}
}
