using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeCinema.Dominio.ModuloCompartilhado;

namespace ControleDeCinema.Dominio.ModuloFilme
{
    public class Filme : EntidadeBase
    {
        public string Titulo { get; set; }

        public string Genero { get; set; }

        public string Duracao { get; set; }

        public Filme()
        {

        }
    }
}