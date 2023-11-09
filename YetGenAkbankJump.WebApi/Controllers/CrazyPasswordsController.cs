using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using YetGenAkbankJump.Shared.Helpers;
using YetGenAkbankJump.Shared.Services;
using YetGenAkbankJump.Shared.Utilities;
using YetGenAkbankJump.WebApi.Services;

namespace YetGenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrazyPasswordsController : ControllerBase
    {
        private readonly PasswordGenerator _passwordGenerator;
        private readonly RequestCountService _requestCountService;
        private readonly IStringLocalizer<CommonTranslations> _localizer;
        private readonly ITextService _textService;
        private readonly IIPService _ipService;

        public CrazyPasswordsController(PasswordGenerator passwordGenerator, RequestCountService requestCountService, IStringLocalizer<CommonTranslations> localizer, ITextService textService, IIPService ipService)
        {
            _passwordGenerator = passwordGenerator;
            _requestCountService = requestCountService;
            _localizer = localizer;
            _textService = textService;
            _ipService = ipService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _requestCountService.Count += 1;

            _ipService.Ip = "192.168.1.38";

            return Ok(_passwordGenerator.Generate(12, true, true, true, true));
        }

        [HttpGet("GetCount")]
        public IActionResult GetCount()
        {
            _requestCountService.Count += 1;
            return Ok(_passwordGenerator.GeneratedPasswordsCount);
        }

        [HttpGet("GetRequestCount")]
        public IActionResult GetRequestCount()
        {
            _requestCountService.Count += 1;

            return Ok(_requestCountService.Count);
        }

    }
}
