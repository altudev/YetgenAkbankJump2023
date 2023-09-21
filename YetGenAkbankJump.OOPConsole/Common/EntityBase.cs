namespace YetGenAkbankJump.OOPConsole.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
