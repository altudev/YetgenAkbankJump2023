namespace YetGenAkbankJump.OOPConsole.Services
{
    public class FileLogger:LoggerBase
    {
        private readonly string _filePath;

        protected internal override string? Name { get; set; } = "Alper Tunga";

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }
        protected internal override void Log(string message)
        {
            File.AppendAllText(_filePath, message);
        }

        protected internal override void LogSuccess(string message)
        {
            File.AppendAllText(_filePath, $"Success => {message}");
        }

        protected internal override void LogError(string message)
        {
            File.AppendAllText(_filePath, $"Error => {message}");
        }

        protected internal override void LogInfo(string message)
        {
            File.AppendAllText(_filePath, $"Info => {message}");
        }

        protected internal override void LogWarning(string message)
        {
            File.AppendAllText(_filePath, $"Warning => {message}");
        }

        protected internal override void LogFatal(string message)
        {
            File.AppendAllText(_filePath, $"Fatal => {message}");

            base.LogFatal(message);
        }

        protected internal override void LogFail(string message)
        {
            throw new NotImplementedException();
        }
    }
}
