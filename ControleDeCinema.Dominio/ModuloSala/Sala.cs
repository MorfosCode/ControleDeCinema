using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeCinema.Dominio.ModuloCompartilhado;

namespace ControleDeCinema.Dominio.ModuloSala
{
    public class Sala : EntidadeBase
    {
        public int Capacidade { get; set; }

        public string Descricao { get; set; }

        public Sala()
        {

        }
    }
}