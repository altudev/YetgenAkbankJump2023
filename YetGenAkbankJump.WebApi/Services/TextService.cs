using YetGenAkbankJump.Shared;
using YetGenAkbankJump.Shared.Services;

namespace YetGenAkbankJump.WebApi.Services
{
    public class TextService : ITextService
    {
        private readonly string _path;
        public TextService()
        {
            _path = "C:\\Users\\alper\\Desktop\\passwords.txt";
        }

        public void Save(string text)
        {
            int number = 2;

            var even = number.IsEven();

            if (text.IsEmpty())
            {
                throw new ArgumentNullException("text cannot be null");
            }

            File.WriteAllText(_path,text);

        }
    }
}
