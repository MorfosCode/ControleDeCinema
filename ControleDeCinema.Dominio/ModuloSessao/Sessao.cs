using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeCinema.Dominio.ModuloCompartilhado;
using ControleDeCinema.Dominio.ModuloFilme;
using ControleDeCinema.Dominio.ModuloSala;

namespace ControleDeCinema.Dominio.ModuloSessao
{
    public class Sessao : EntidadeBase
    {
        public string DescricaoSessao { get; set; }

        public bool Status { get; set; }

        public DateTime DataSessao { get; set; }

        public DateTime HorarioSessao { get; set; }

        public Filme Filme { get; set; }

        public Sala Sala { get; set; }

        public Sessao()
        {

        }
    }
}