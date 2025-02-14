using Academia.Domain.AlunoModulo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academia.Infra.Data.EF.Alunos
{
    public class AlunoEntityConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(p => p.AlunoId);

            builder.Property(p => p.Nome).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Altura);
            builder.Property(p => p.Peso);
            builder.Property(p => p.Email);
            builder.Property(p => p.Telefone);

            //Relações
            builder.HasOne(p => p.ProfessorResponsavel).WithMany(o => o.Alunos).HasForeignKey(x => x.ProfessorResponsavelId);
        }
    }
}
