using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeCinema.Dominio.ModuloCompartilhado;

namespace ControleDeCinema.Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase
    {
        public string NomeFuncionario { get; set; }

        public string Cpf { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public Funcionario()
        {

        }
    }
}