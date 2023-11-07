namespace YetgenAkbankJump.BlazorDI.Services
{
    public interface IToasterService
    {
        void ShowSuccess(string message);
        void ShowInfo(string message);
        void ShowWarning(string message);
    }
}
