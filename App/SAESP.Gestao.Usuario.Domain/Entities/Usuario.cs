using SAESP.Gestao.SharedKernel.Entities;
using SAESP.Gestao.Usuario.Domain.ValueObjects;
using System;

namespace SAESP.Gestao.Usuario.Domain.Entities
{
    public class Usuario : Entity
    {
        public Usuario()
        {

        }

        public Name Nome { get; set; }

        public MatriculaSBA MatriculaSba { get; set; }

        public DateTime DateBirth { get; set; }

        public string Classificao { get; set; }

        public CPF Cpf { get; set; }

        public int MyProperty { get; set; }

    }
}