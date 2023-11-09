namespace YetgenAkbankJump.Domain.Entities
{
    public interface ICreatedByEntity
    {
        public string CreatedByUserId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
