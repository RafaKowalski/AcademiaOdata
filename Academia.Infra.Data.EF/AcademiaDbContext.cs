using Academia.Domain.AlunoModulo;
using Academia.Domain.ProfessorModulo;
using Microsoft.EntityFrameworkCore;

namespace Academia.Infra.Data.EF
{
    public class AcademiaDbContext : DbContext
    {
        public AcademiaDbContext(DbContextOptions<AcademiaDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                throw new System.Exception("O DbContext está sendo usado sem configuração. Use a injeção de dependência ou uma fábrica.");
            }
        }
    }
}
