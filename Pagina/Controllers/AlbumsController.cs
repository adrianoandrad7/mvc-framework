using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcFrameWork.Models;
using Pagina.Models;
using Pagina.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Pagina.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AlbumsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ApiServices apiServices = new ApiServices();
            var listaAlbums = new List<Albums>();

            var retunApi = apiServices.IntegrarAPIJson();  
            listaAlbums = retunApi;

            return View(listaAlbums);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
