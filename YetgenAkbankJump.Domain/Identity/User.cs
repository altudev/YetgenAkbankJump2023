using Microsoft.AspNetCore.Identity;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Domain.Enums;

namespace YetgenAkbankJump.Domain.Identity
{
    public class User:IdentityUser<Guid>,IEntityBase<Guid>,ICreatedByEntity,IModifiedByEntity
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public DateTimeOffset? BirthDate { get; set; }
        public Gender Gender { get; set; }

        public UserSetting UserSetting { get; set; }

        public string CreatedByUserId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string? ModifiedByUserId { get; set; }
        public DateTimeOffset? LastModifiedOn { get; set; }
    }
}
