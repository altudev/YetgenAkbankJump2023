namespace YetgenAkbankJump.Domain.Entities
{
    public class Product:EntityBase<Guid>
    {
        public string Name { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
