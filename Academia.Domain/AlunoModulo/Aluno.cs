﻿using System.Text.Json.Serialization;
using Academia.Domain.ProfessorModulo;

namespace Academia.Domain.AlunoModulo
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }
        public required string Nome { get; set; }
        public string? Altura { get; set; }
        public string? Peso { get; set; }

        public string? Email { get; set; }

        public string? Telefone { get; set; }
        [JsonIgnore]
        public Professor? ProfessorResponsavel { get; set; }
        public Guid ProfessorResponsavelId { get; set; }
    }
}
