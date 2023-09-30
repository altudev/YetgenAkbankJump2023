using YetGenAkbankJump.OOPConsole.Common;
using YetGenAkbankJump.OOPConsole.Utilities;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class Teacher: EntityBase<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }

        public static implicit operator Teacher(Student student)
        {
            return new Teacher()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                CreatedOn = student.CreatedOn
            };
        }

        //public static explicit operator Teacher(Student student)
        //{
        //    return new Teacher()
        //    {
        //        FirstName = student.FirstName,
        //        LastName = student.LastName,
        //        CreatedOn = student.CreatedOn,
        //    };
        //}

        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

    }
}
