using Microsoft.AspNetCore.Mvc;

namespace ConfigurationExample.Controllers
{
	public class HomeController : Controller
	{
		// Private field
		private readonly IConfiguration _configuration;

		// Constructor
		public HomeController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		[Route("/")]
		public IActionResult Index()
		{
			// ViewBag.CliendID = _configuration["weatherapi"];
			// ViewBag.ClientSecret = _configuration.GetValue("weatherapi:ClientSecret", "the default client secret");

			IConfigurationSection weatherapiSection = _configuration.GetSection("weatherapi");

			ViewBag.CliendID = weatherapiSection["ClientID"];

			ViewBag.ClientSecret = weatherapiSection["ClientSecret"];

			return View();
		}
	}
}
