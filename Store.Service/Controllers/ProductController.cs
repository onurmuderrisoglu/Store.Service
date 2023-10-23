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
		public IActionResult AddProduct(Products products)
		{
			_productService.AddProduct(products);
			return Ok();
		}
		[HttpPost()]
		[Route("DeleteProduct")]
		public IActionResult DeleteProduct(int id)
		{
			_productService.DeleteProduct(id);
			return Ok();
		}
		[HttpGet()]
		[Route("GetAllProducts")]
		public IActionResult GetAllProducts()
		{
			var prdocuts = _productService.GetAllProducts();
			return Ok(prdocuts);
		}
	}
}
