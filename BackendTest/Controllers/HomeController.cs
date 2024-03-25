using BackendTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BackendTest.Manager;

namespace BackendTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly UtilityManager _utilityManager;

        public HomeController(UtilityManager utilityManager)
        {
            _utilityManager = utilityManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
       
        public IActionResult GetNthFromEnd(string arr, int n)
        {
            // Converti la stringa di numeri separati da virgola in un array di interi
            int[] numbers = arr.Split(',').Select(int.Parse).ToArray();

            // Esegui il test
            var result = _utilityManager.GetNthFromEnd(numbers, n);
            ViewData["ResultGetNthFromEnd"] = result;
            return View("Index");
        }

        [HttpPost]
        public IActionResult ReverseWords(string regularPhrase)
        {
            var result = _utilityManager.ReverseWords(regularPhrase);
            ViewData["ResultReverseWords"] = result;
            return View("Index");
        }

        [HttpPost]
        public IActionResult TriangleCategorisation(int sideA, int sideB, int sideC)
        {
            var result = _utilityManager.CategorizeTriangle(sideA, sideB, sideC);
            ViewData["ResultTriangleCategorisation"] = result;
            return View("Index");
        }
    }
}
