using System.CodeDom.Compiler;
using YetGenAkbankJump.Shared.Services;

namespace YetGenAkbankJump.MVCClient.Services
{
    public class MvcTextService:ITextService
    {
        public void Save(string text)
        {
            //using (TextWriter textWriter = new IndentedTextWriter(new StringWriter()))
            //{
            //    textWriter.Write(text);
            //}


            File.WriteAllTextAsync("C:\\Users\\alper\\Desktop\\TextFiles\\",text);
        }
    }
}
