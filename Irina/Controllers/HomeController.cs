using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Irina.Interfaces;
using Irina.Models;

namespace Irina.Controllers
{
  public class HomeController : Controller, IPortfolio
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    
    public IActionResult Index()
    {
      //  Home S = new Home();
      // string[] u = S.Main();
      // foreach (string f in u)
      //  ViewBag.Anna = f;

       Home viewModel = new Home();
       viewModel.Main();
        ViewBag.Name = Getname();
      return View(viewModel);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [HttpGet]
    public string Getname()
    {
      
      return "Hello";

    }

  }
}
