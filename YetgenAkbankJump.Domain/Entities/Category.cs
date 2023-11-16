namespace YetgenAkbankJump.Domain.Entities
{
    public class Category:EntityBase<Guid>
    {
        public string Name { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }

        // dbContext.Categories.Include(x=>x.Products).FirstOrDefaultAsync(x=>x.Id == 12345);

        // category.Products
    }
}
