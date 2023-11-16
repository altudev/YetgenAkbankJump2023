using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YetgenAkbankJump.Domain.Dtos;
using YetgenAkbankJump.Domain.Entities;
using YetGenAkbankJump.Persistence.Contexts;

namespace YetGenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoriesController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CategoryAddDto categoryAddDto, CancellationToken cancellationToken)
        {

            if (categoryAddDto is null)
                return BadRequest("Category's name cannot be null");

            var category = new Category()
            {
                Id = Guid.NewGuid(),
                Name = categoryAddDto.Name,
                CreatedByUserId = "kalaymaster",
                CreatedOn = DateTimeOffset.UtcNow,
                IsDeleted = false,
            };

            await _applicationDbContext.Categories.AddAsync(category,cancellationToken);

            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(category);
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var category = await _applicationDbContext
                .Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            return Ok(category);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var categories = await _applicationDbContext
                .Categories
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            return Ok(categories);
        }
    }
}
