using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academia.Infra.Data.EF.Migrations
{
    /// <inheritdoc />
    public partial class PopulaTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Popula tabela professores
            migrationBuilder.Sql("Insert into Professores(professorId, nome) Values(1 ,'Kowalski')");
            migrationBuilder.Sql("Insert into Professores(professorId, nome) Values(2 ,'Rafael')");
            migrationBuilder.Sql("Insert into Professores(professorId, nome) Values(3 ,'Rockeiro')");

            //Popula tabela alunos
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values(1, 'Jao', '1,55', '47kg', 'jao@hotmail.com', '32224438',1)");
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values(2, 'Otario', '1,75', '78kg', 'otario@hotmail.com', '32224432',2)");
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values(3, 'Varginha', '1,63', '60kg', 'varginha@hotmail.com', '32235677',1)");
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values(4, 'Vader', '1,89', '93kg', 'vader@hotmail.com', '898977643',3)");
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values(5, 'Yoda', '1,10', '20kg', 'yoda@hotmail.com', '4545312345',2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Professores
            migrationBuilder.Sql("Delete From Professores");

            // Alunos
            migrationBuilder.Sql("Delete From Alunos");
        }
    }
}
