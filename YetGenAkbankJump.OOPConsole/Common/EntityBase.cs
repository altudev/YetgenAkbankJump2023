namespace YetGenAkbankJump.OOPConsole.Common
{
    public class EntityBase<TKey>:ICreatedByEntity, IDeletedByEntity
    {
        public TKey Id { get; set; }

        public string ModifiedByUserId { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }

        public string DeletedByUserId { get; set; }
        public DateTimeOffset DeletedOn { get; set; }
        public bool IsDeleted { get; set; }

        public string CreatedByUserId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
