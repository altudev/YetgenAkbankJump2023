namespace YetGenAkbankJump.OOPConsole.Services
{
    public class MobileLogger:LoggerBase
    {
        protected internal override void Log(string message)
        {
            throw new NotImplementedException();
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

        protected internal override void LogFatal(string message)
        {
           File.WriteAllText("ApplicationFolder/DCIM",message);

            base.LogFatal(message);
        }
    }
}
