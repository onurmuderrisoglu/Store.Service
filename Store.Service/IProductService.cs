using Store.Model;

namespace Store.Service
{
	public interface IProductService
	{
		IEnumerable<Products> GetAllProducts();
		void DeleteProduct(int id);
		void AddProduct(Products products);
	}
}
