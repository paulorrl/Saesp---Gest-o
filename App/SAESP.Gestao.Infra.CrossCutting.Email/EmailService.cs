using SAESP.Gestao.SharedKernel.Services;
using System;

namespace SAESP.Gestao.Infra.Email
{
    public sealed class EmailService : IEmailService
    {
        public void Send(string name, string email, string subject, string body)
        {
            Console.WriteLine("Email enviado com sucesso!");
        }
    }
}