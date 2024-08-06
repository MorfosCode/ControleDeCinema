using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeCinema.Dominio.ModuloCompartilhado;
using ControleDeCinema.Dominio.ModuloSessao;

namespace ControleDeCinema.Dominio.ModuloIngresso
{
    public class Ingresso : EntidadeBase
    {
        public string Tipo { get; set; }

        public decimal ValorInteiro { get; set; }

        public decimal ValorMeio { get; set; }

        public Sessao Sessao { get; set; }

        public Assento Assento { get; set; }

        public DateTime DataCompra { get; set; }

        public Ingresso()
        {

        }
    }
}