using Academia.Domain.ProfessorModulo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academia.Infra.Data.EF.Professores
{
    public class professorEntityConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professores");

            builder.HasKey(p => p.ProfessorId);
            builder.Ignore(p => p.Alunos);

            builder.Property(p => p.Nome).IsRequired().HasMaxLength(255);
        }
    }
}
