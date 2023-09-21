using YetGenAkbankJump.OOPConsole.Common;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class Teacher: EntityBase<long>
    {
        public DateTimeOffset RegistrationDate { get; set; }


        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

    }
}
