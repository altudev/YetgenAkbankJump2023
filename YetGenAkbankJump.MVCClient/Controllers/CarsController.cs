using System.Net;
using Microsoft.AspNetCore.Mvc;
using YetgenAkbankJump.Domain.Entities;

namespace YetGenAkbankJump.MVCClient.Controllers
{
    public class CarsController : Controller
    {
        private readonly HttpClient _httpClient;

        public CarsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("Cars");

            if (response.StatusCode == HttpStatusCode.OK)
            {

                var cars = await response.Content.ReadFromJsonAsync<List<Car>>();

                return View(cars);
            }else if (response.StatusCode == HttpStatusCode.NotFound)
            {

            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {

            }

            return NotFound();


        }
    }
}
