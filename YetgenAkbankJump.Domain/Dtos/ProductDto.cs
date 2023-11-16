namespace YetgenAkbankJump.Domain.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<ProductGetAllCategoryDto> Categories { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
