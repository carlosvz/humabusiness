﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HumaBusiness.WebUI.Controllers
{
    public class TablesController : Controller
    {
        private readonly ApplicationSettings _settings;

        public TablesController(IOptions<ApplicationSettings> settings)
        {
            _settings = settings.Value;
        }
        // GET
        public IActionResult Basic() => View(_settings);
        public IActionResult GenerateStyle() => View(_settings);
    }
}