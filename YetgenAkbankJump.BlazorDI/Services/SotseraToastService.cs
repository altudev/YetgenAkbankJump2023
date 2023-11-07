using Sotsera.Blazor.Toaster;

namespace YetgenAkbankJump.BlazorDI.Services
{
    public class SotseraToastService:IToasterService
    {
        private readonly IToaster _toaster;
            
        public SotseraToastService(IToaster toaster)
        {
            _toaster = toaster;
        }

        public void ShowSuccess(string message)
        {
            _toaster.Success(message);
        }

        public void ShowInfo(string message)
        {
            _toaster.Info(message);
        }

        public void ShowWarning(string message)
        {
            _toaster.Warning(message);
        }
    }
}
