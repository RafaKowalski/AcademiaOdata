﻿using Academia.Domain.AlunoModulo;

namespace Academia.Application.AlunoModulo.Services
{
    public interface IAlunoServices
    {
        Task<IEnumerable<Aluno>> GetAllAlunos();
        Task<Aluno> GetAlunoById(Guid id);
        Task<Aluno> AddAluno(Aluno aluno);
    }
}
