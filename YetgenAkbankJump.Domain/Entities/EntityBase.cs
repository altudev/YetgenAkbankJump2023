namespace YetgenAkbankJump.Domain.Entities
{
    public abstract class EntityBase<TKey>:IEntityBase<TKey>,ICreatedByEntity,IModifiedByEntity,IDeletedByEntity
    {
        public virtual TKey Id { get; set; }

        public virtual string CreatedByUserId { get; set; }
        public virtual DateTimeOffset CreatedOn { get; set; }
        public virtual string? ModifiedByUserId { get; set; }
        public virtual DateTimeOffset? LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public virtual string? DeletedByUserId { get; set; }
        public virtual DateTimeOffset? DeletedOn { get; set; }

        public bool Equals(TKey? other)
        {
            throw new NotImplementedException();
        }
    }
}
