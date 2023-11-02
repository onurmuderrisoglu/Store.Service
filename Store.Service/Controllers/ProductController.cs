using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Model;

namespace Store.Service.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private IProductService _productService;
		public ProductController(IProductService productService)
		{
			_productService = productService;
		}
		[HttpPost()]
		[Route("AddProduct")]
		public async Task<IActionResult> AddProduct(Products products)
		{
			await _productService.AddProduct(products);
			return Ok();
		}
		[HttpPost()]
		[Route("DeleteProduct")]
		public async Task<IActionResult> DeleteProduct(int id)
		{
			await _productService.DeleteProduct(id);
			return Ok();
		}
		[HttpGet()]
		[Route("GetAllProducts")]
		public async Task<IActionResult> GetAllProducts()
		{
			var products = await _productService.GetAllProducts();
			return Ok(products);
		}

		[HttpGet()]
		[Route("GetProductById")]
		public async Task<IActionResult> GetProductById(int id)
		{
			var products = await _productService.GetProductById(id);
			return Ok(products);
		}
	}
}
