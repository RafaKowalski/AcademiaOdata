using Academia.Application.AlunoModulo.Commands;
using Academia.Domain.AlunoModulo;
using AutoMapper;

namespace Academia.Application.AlunoModulo.Mappers
{
    public class AddAlunoMapper : Profile
    {
        public AddAlunoMapper()
        {
            CreateMap<AddAlunoCommand, Aluno>();
            CreateMap<Aluno, AddAlunoCommand>();
        }
    }
}
