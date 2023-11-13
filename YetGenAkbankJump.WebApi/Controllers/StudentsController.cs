using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using YetgenAkbankJump.Domain.Entities;
using YetGenAkbankJump.Persistence.Contexts;
using YetGenAkbankJump.WebApi.Services;

namespace YetGenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly FakeDataService _fakeDataService;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions _cacheEntryOptions;
        private const string StudentsCacheKey = "studentsList";

        public StudentsController(FakeDataService fakeDataService, ApplicationDbContext applicationDbContext, IMemoryCache memoryCache)
        {
            _fakeDataService = fakeDataService;
            _applicationDbContext = applicationDbContext;
            _memoryCache = memoryCache;

            _cacheEntryOptions = new MemoryCacheEntryOptions()
            {
                Priority = CacheItemPriority.High,
                AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(30),
            };
        }

        [HttpPost("GenerateFakeData")]
        public async Task<IActionResult> GenerateFakeDataAsync(CancellationToken cancellationToken)
        {
            await _fakeDataService.GenerateStudentDataAsync(cancellationToken);

           var students = await _applicationDbContext
               .Students.AsNoTracking()
               .ToListAsync(cancellationToken);

            _memoryCache.Set(StudentsCacheKey, students, _cacheEntryOptions);

            return Ok(await _fakeDataService.GenerateStudentDataAsync(cancellationToken));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            List<Student> students = new List<Student>();

            if (_memoryCache.TryGetValue(StudentsCacheKey, out students))
            {
                return Ok(students);
            }


            students = await _applicationDbContext.Students.AsNoTracking().ToListAsync(cancellationToken);

            _memoryCache.Set(StudentsCacheKey, students, _cacheEntryOptions);

            return Ok(students);
        }
    }
}
