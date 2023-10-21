using Store.Model;

namespace Store.Service
{
	public interface IProductsService
	{
		IEnumerable<Products> GetAll();
		void DeleteProduct(int id);
		void AddProduct(Products products);
	}
}
