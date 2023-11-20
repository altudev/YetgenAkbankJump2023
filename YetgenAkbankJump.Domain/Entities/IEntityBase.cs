namespace YetgenAkbankJump.Domain.Entities
{
    public interface IEntityBase<TKey>
    {
        public TKey Id { get; set; }
    }
}
