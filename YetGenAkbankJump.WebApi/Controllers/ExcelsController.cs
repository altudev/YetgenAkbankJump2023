using Microsoft.AspNetCore.Mvc;
using YetgenAkbankJump.Domain.Dtos;
using YetGenAkbankJump.Persistence.Utilities;

namespace YetGenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelsController : ControllerBase
    {
        //private readonly ExcelManager _excelManager;

        //public ExcelsController(ExcelManager excelManager)
        //{
        //    _excelManager = excelManager;
        //}

        //[HttpPost("AddCountries")]
        //public async Task<IActionResult> AddCountries(ExcelLoadFileDto excelLoadFileDto, CancellationToken cancellationToken)
        //{
        //    await _excelManager.LoadCountriesAsync(excelLoadFileDto, cancellationToken);

        //    return Ok();
        //}

        //[HttpPost("AddCities")]
        //public async Task<IActionResult> AddCities(ExcelLoadFileDto excelLoadFileDto, CancellationToken cancellationToken)
        //{
        //    await _excelManager.LoadCitiesAsync(excelLoadFileDto,cancellationToken);

        //    return Ok();
        //}
    }
}
