namespace YetgenAkbankJump.Domain.Dtos
{
    public class ProductAddDto
    {
        public string Name { get; set; }
        public List<Guid> CategoryIds { get; set; }
    }
}
