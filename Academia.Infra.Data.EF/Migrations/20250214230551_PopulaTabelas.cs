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
            migrationBuilder.Sql("Insert into Professores(professorId, nome) Values('4610f22a-5670-4d49-b2b8-1481d553cacd' ,'Kowalski')");
            migrationBuilder.Sql("Insert into Professores(professorId, nome) Values('9cc7e8c6-852a-433f-b64d-cdb573847ac4' ,'Rafael')");
            migrationBuilder.Sql("Insert into Professores(professorId, nome) Values('c5f4e3e1-c0d3-49ce-8f3c-2289c03d3a9e' ,'Rockeiro')");

            //Popula tabela alunos
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values('c8ba8f25-bcaa-4da6-a659-ba52501a059e', 'Jao', '1,55', '47kg', 'jao@hotmail.com', '32224438','4610f22a-5670-4d49-b2b8-1481d553cacd')");
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values('0a806431-1322-45d8-a71e-98276d36e471', 'Otario', '1,75', '78kg', 'otario@hotmail.com', '32224432','9cc7e8c6-852a-433f-b64d-cdb573847ac4')");
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values('eeca9b48-1d7c-4b0c-8796-02319f7e8aeb', 'Varginha', '1,63', '60kg', 'varginha@hotmail.com', '32235677','c5f4e3e1-c0d3-49ce-8f3c-2289c03d3a9e')");
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values('388011e4-740c-4774-bd7b-0aa8dfed0b7a', 'Vader', '1,89', '93kg', 'vader@hotmail.com', '898977643','4610f22a-5670-4d49-b2b8-1481d553cacd')");
            migrationBuilder.Sql("Insert into Alunos(alunoId, nome, altura, peso, email, telefone, professorResponsavelId) Values('e3e93039-5cc0-486d-bfaa-980f2d7b4138', 'Yoda', '1,10', '20kg', 'yoda@hotmail.com', '4545312345','9cc7e8c6-852a-433f-b64d-cdb573847ac4')");
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
