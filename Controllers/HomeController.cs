using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AS1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AS1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new Conversion());
            
        }

        [HttpPost]
        public IActionResult Index(Conversion c, string ConvertSL)
        {
            if(ConvertSL == "ConvertB")
            {
                string Result = string.Empty;
                for (int i = 0; c.Decimal1 > 0; i++)
                {
                    Result = c.Decimal1 % 2 + Result;
                    c.Decimal1 = c.Decimal1 / 2;
                    c.Binary = Result;
                }
            }

            else if(ConvertSL == "ConvertH")
            {
                int dec = c.Decimal2;
                int hex = dec;
                string hexStr = string.Empty;

                while (dec > 0)
                {
                    hex = dec % 16;

                    if (hex < 10)
                        hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                    else
                        hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());

                    dec /= 16;
                    c.HexaDecimal = hexStr;
                }
            }
            return View(c);
        }

    }
}
