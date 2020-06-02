using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Irina.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Irina.Controllers
{
    public class AboutController : Controller, ICloneable
    {
    public object Clone()
    {
      throw new NotImplementedException();
    }
    

    public IActionResult Index()
        {
            return View();
        }
    }
}