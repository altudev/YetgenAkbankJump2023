using YetGenAkbankJump.OOPConsole.Common;

namespace YetGenAkbankJump.OOPConsole.Entities
{
    public class Student : PersonBase
    {
        public int No { get; set; }
      
        public DateTimeOffset RegistrationDate { get; set; }
    }
}
