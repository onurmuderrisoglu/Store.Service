using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Model;

namespace Store.Service.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private IProductsService _productsService;
		public ProductController(IProductsService productsService)
		{
			_productsService = productsService;
		}
		[HttpPost()]
		[Route("api/[controller]/SaveProduct")]
		public IActionResult SaveProduct(Products products)
		{
			_productsService.AddProduct(products);
			return Ok();
		}
		[HttpPost()]
		[Route("api/[controller]/DeleteProduct")]
		public IActionResult DeleteProduct(int id)
		{
			_productsService.DeleteProduct(id);
			return Ok();
		}
	}
}
