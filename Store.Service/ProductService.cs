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

		public async Task AddProduct(Products products)
		{
			_dbContext.Add(products);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteProduct(int id)
		{
			var entity = await GetProductById(id);
			_dbContext.Set<Products>().Remove(entity);
			_dbContext.SaveChanges();
		}

		public async Task<IEnumerable<Products>> GetAllProducts()
		{
			return await _dbContext.Products.ToListAsync();
		}

		public async Task<Products> GetProductById(int id)
		{
			return await _dbContext.Set<Products>().FindAsync(id);
		}		
	}
}
