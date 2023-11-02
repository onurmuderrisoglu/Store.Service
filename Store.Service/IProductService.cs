using Store.Model;

namespace Store.Service
{
	public interface IProductService
	{
		Task<IEnumerable<Products>> GetAllProducts();
		Task DeleteProduct(int id);
		Task AddProduct(Products products);
		Task<Products> GetProductById(int id);
	}
}
