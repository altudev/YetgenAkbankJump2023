using System.Net.Http.Json;

namespace YetGenAkbankJump.OOPConsole.Services
{
    public class WebLogger:LoggerBase
    {
        private readonly HttpClient _httpClient;

        public WebLogger()
        {
            _httpClient=new HttpClient();
        }

        protected internal override void Log(string message)
        {
            _httpClient.PostAsJsonAsync("/Yetgen/Api/Logs", message);
        }

        protected internal override void LogSuccess(string message)
        {
            throw new NotImplementedException();
        }

        protected internal override void LogError(string message)
        {
            throw new NotImplementedException();
        }

        protected internal override void LogInfo(string message)
        {
            throw new NotImplementedException();
        }

        protected internal override void LogWarning(string message)
        {
            throw new NotImplementedException();
        }

        protected internal override void LogFail(string message)
        {
            throw new NotImplementedException();
        }
    }
}
