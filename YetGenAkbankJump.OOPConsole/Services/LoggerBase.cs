namespace YetGenAkbankJump.OOPConsole.Services
{
    public abstract class LoggerBase
    {
        protected internal virtual string? Name { get; set; }
        protected internal abstract void Log(string message);
        protected internal abstract void LogSuccess(string message);
        protected internal abstract void LogError(string message);
        protected internal abstract void LogInfo(string message);
        protected internal abstract void LogWarning(string message);

        protected internal virtual void LogFatal(string message)
        {
            Console.WriteLine($"Fatal => {message}");
        }

        protected internal abstract void LogFail(string message);

        protected internal LoggerBase(string name)
        {
            Name = name;
        }

        protected internal LoggerBase()
        {
            
        }
    }
}
