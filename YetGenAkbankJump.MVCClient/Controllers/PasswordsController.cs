using Microsoft.AspNetCore.Mvc;
using YetGenAkbankJump.MVCClient.Models;
using YetGenAkbankJump.Shared.Utilities;

namespace YetGenAkbankJump.MVCClient.Controllers
{
    public class PasswordsController : Controller
    {

        private readonly PasswordGenerator _passwordGenerator;

        public PasswordsController()
        {
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            var indexViewModel = new PasswordsIndexViewModel();

            indexViewModel.Password = _passwordGenerator.Generate(15, true, true, true, true);


            return View(indexViewModel);
        }


        [HttpPost]
        public IActionResult Index(int passwordLength)
        {
            //var indexViewModel = new PasswordsIndexViewModel();

            //indexViewModel.Password = _passwordGenerator.Generate(passwordLength, true, true, true, true);

            //return View(indexViewModel);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Add()
        {
            var indexViewModel = new PasswordsIndexViewModel();

            indexViewModel.Password = _passwordGenerator.Generate(15, true, true, true, true);


            return View(indexViewModel);
        }


        [HttpPost]
        public IActionResult Add(PasswordsIndexViewModel passwordModel)
        {
            return View();
        }
    }
}
