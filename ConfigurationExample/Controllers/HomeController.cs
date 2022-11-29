﻿using Microsoft.AspNetCore.Mvc;

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
			ViewBag.MyKey = _configuration["MyKey"];
			ViewBag.MyAPIKey = _configuration.GetValue("MyAPIKey", "the default key");

			return View();
		}
	}
}
