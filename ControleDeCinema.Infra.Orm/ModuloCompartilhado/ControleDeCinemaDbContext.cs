using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeCinema.Dominio;
using ControleDeCinema.Dominio.ModuloFilme;
using ControleDeCinema.Dominio.ModuloFuncionario;
using ControleDeCinema.Dominio.ModuloIngresso;
using ControleDeCinema.Dominio.ModuloSala;
using ControleDeCinema.Dominio.ModuloSessao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ControleDeCinema.Infra.Orm.ModuloCompartilhado
{
	public class ControleDeCinemaDbContext : DbContext
	{
		public DbSet<Assento> Assentos { get; set; }

		public DbSet<Filme> Filmes { get; set; }

		public DbSet<Funcionario> Funcionarios { get; set; }

		public DbSet<Ingresso> Ingressos { get; set; }

		public DbSet<Sala> Salas { get; set; }

		public DbSet<Sessao> Sessoes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Configuração da connectionString que valida qual banco de dados está sendo usado,
			// o caminho e o banco está sendo descrito no arquivo json
			IConfigurationRoot config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			string connectionString = config.GetConnectionString("SqlServer")!;

			optionsBuilder.UseSqlServer(connectionString);

			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Funcionario>(filmeBuilder =>
			{
				filmeBuilder.ToTable("TBFuncionario");
				filmeBuilder.Property(f => f.Id).IsRequired().ValueGeneratedOnAdd();
				filmeBuilder.Property(f => f.NomeFuncionario).IsRequired();
				filmeBuilder.Property(f => f.Cpf).IsRequired();
				filmeBuilder.Property(f => f.Login).IsRequired();
				filmeBuilder.Property(f => f.Senha).IsRequired();
			});

			modelBuilder.Entity<Filme>(filmeBuilder =>
			{
				filmeBuilder.ToTable("TBFilme");
				filmeBuilder.Property(f => f.Id).IsRequired().ValueGeneratedOnAdd();
				filmeBuilder.Property(f => f.Titulo).IsRequired();
				filmeBuilder.Property(f => f.Genero).IsRequired();
				filmeBuilder.Property(f => f.Duracao).IsRequired();
			});

			modelBuilder.Entity<Sala>(salaBuilder =>
			{
				salaBuilder.ToTable("TBSala");
				salaBuilder.Property(s => s.Id).IsRequired().ValueGeneratedOnAdd();
				salaBuilder.Property(s => s.Capacidade).IsRequired().HasColumnType("int");
				salaBuilder.Property(s => s.Descricao).IsRequired();
			});

			modelBuilder.Entity<Assento>(assentoBuilder =>
			{
				assentoBuilder.ToTable("TBAssento");
				assentoBuilder.Property(a => a.Id).IsRequired().ValueGeneratedOnAdd();
				assentoBuilder.Property(a => a.DescricaoAssento).IsRequired();
				assentoBuilder.Property(a => a.Status).IsRequired().HasColumnType("bit");
				
				assentoBuilder.HasOne(a => a.Sala)
					.WithMany()
					.HasForeignKey("Sala_Id")
					.HasConstraintName("FK_TBAssento_TBSala")
					.IsRequired()
					.OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Sessao>(sessaoBuilder =>
			{
				sessaoBuilder.ToTable("TBSessao");
				sessaoBuilder.Property(s => s.Id).IsRequired().ValueGeneratedOnAdd();
				sessaoBuilder.Property(s => s.DescricaoSessao).IsRequired();
				sessaoBuilder.Property(s => s.Status).IsRequired();
				sessaoBuilder.Property(s => s.DataSessao).IsRequired().HasColumnType("datetime2");
				sessaoBuilder.Property(s => s.HorarioSessao).IsRequired().HasColumnType("datetime2");

				sessaoBuilder.HasOne(s => s.Filme)
					.WithMany()
					.HasForeignKey("Filme_Id")
					.HasConstraintName("FK_TBSessao_TBFilme")
					.IsRequired()
					.OnDelete(DeleteBehavior.Restrict);

				sessaoBuilder.HasOne(s => s.Sala)
					.WithMany()
					.HasForeignKey("Sala_Id")
					.HasConstraintName("FK_TBSessao_TBSala")
					.IsRequired()
					.OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Ingresso>(ingressoBuilder =>
			{
				ingressoBuilder.ToTable("TBIngresso");
				ingressoBuilder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
				ingressoBuilder.Property(i => i.Tipo).IsRequired();
				ingressoBuilder.Property(i => i.ValorInteiro).IsRequired();
				ingressoBuilder.Property(i => i.ValorMeio).IsRequired();
				ingressoBuilder.Property(i => i.DataCompra).IsRequired().HasColumnType("datetime2");
				
				ingressoBuilder.HasOne(i => i.Sessao)
					.WithMany()
					.HasForeignKey("Sessao_Id")
					.HasConstraintName("FK_TBIngresso_TBSessao")
					.IsRequired()
					.OnDelete(DeleteBehavior.Restrict);

				ingressoBuilder.HasOne(i => i.Assento)
					.WithMany()
					.HasForeignKey("Assento_Key")
					.HasConstraintName("FK_TBIngresso_TBAssento")
					.IsRequired()
					.OnDelete(DeleteBehavior.Restrict);
			});
		}
	}
}
