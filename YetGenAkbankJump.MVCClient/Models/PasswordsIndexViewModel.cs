namespace YetGenAkbankJump.MVCClient.Models
{
    public class PasswordsIndexViewModel
    {
        public string Password { get; set; }
        public List<string> Passwords { get; set; }

        public int PasswordLength { get; set; }
        public bool IncludeNumbers { get; set; }
    }
}
