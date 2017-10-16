using SAESP.Gestao.SharedKernel.Services;
using System;

namespace SAESP.Gestao.Infra.Logger
{
    public class LogService : ILogService
    {
        public void Log(string level, string message)
        {
            Console.WriteLine("Registrando log");
        }
    }
}