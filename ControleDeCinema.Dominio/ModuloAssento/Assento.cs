using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeCinema.Dominio.ModuloCompartilhado;
using ControleDeCinema.Dominio.ModuloSala;

namespace ControleDeCinema.Dominio
{
    public class Assento : EntidadeBase
	{
		public string DescricaoAssento { get; set; }

		public bool Status { get; set; }

		public Sala Sala { get; set; }

		public Assento()
		{

		}
	}
}