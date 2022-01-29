using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<ResultDTO> _resultService;

        public HomeController()
        {
            this._resultService = new ResultService();
        }

        public IActionResult Index()
        {
            var results = _resultService.GetAll();
            return View(results);
        }
    }
}