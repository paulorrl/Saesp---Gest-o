namespace SAESP.Gestao.SharedKernel.Services
{
    public interface IEmailService
    {
        void Send(string name, string email, string subject, string body);
    }
}