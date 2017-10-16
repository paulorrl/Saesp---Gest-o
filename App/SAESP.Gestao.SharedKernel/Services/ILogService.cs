namespace SAESP.Gestao.SharedKernel.Services
{
    public interface ILogService
    {
        void Log(string level, string message);
    }
}