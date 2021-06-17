using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace SmartAdmin.WebUI.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Items() => View(_settings);
        public IActionResult New() => View(_settings);
        private readonly ApplicationSettings _settings;

        public StockController(IOptions<ApplicationSettings> settings)
        {
            _settings = settings.Value;
        }
    }
}
