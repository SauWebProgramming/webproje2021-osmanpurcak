using IsTeYazilim.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IsTeYazilim.Controllers
{
    public class ProductController : Controller
    {
        private readonly IStringLocalizer<ProductController> _localizer;

        public ProductController(IStringLocalizer<ProductController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var message = _localizer["Message"];
            ViewData["Message"] = message;
            return View();
        }

        public IActionResult Product()
        {

            var categories = new List<Category>()
            {
                new Category(){CategoryID=1, Name="YazarKasa"},
                new Category(){CategoryID=2, Name="Pos"},
            };
            return View(categories);
        }

        public IActionResult YazarKasa()
        {
            var categories = new List<Category>()
            {
                new Category(){CategoryID=1, Name="POSPAD 101", },
                new Category(){CategoryID=2, Name="İNGENİCO İWE 280"},
                new Category(){CategoryID=3, Name="Yazar Kasa 220TR"},
                new Category(){CategoryID=4, Name="OLİVETTİ PBT900"}
            };
            return View(categories);
        }

        public IActionResult Pos()
        {
            var categories = new List<Category>()
            {
                new Category(){CategoryID=1, Name="Verifone"},
                new Category(){CategoryID=2, Name="İnfotek"},
                new Category(){CategoryID=3, Name="VERA"},
            };
            return View(categories);
        }

    }
}
