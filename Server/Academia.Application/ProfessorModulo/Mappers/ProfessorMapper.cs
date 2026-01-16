using Academia.Application.ProfessorModulo.Queries;
using Academia.Domain.ProfessorModulo;
using AutoMapper;

namespace Academia.Application.ProfessorModulo.Mappers
{
    public class ProfessorMapper : Profile
    {
        public class GetAllProfessoresMapper : Profile
        {
            public GetAllProfessoresMapper()
            {
                CreateMap<IEnumerable<Professor>, IEnumerable<GetAllProfessoresQuery>>();
                CreateMap<IEnumerable<GetAllProfessoresQuery>, IEnumerable<Professor>>();
            }
        }

        public class GetProfessorByIdMapper : Profile
        {
            public GetProfessorByIdMapper()
            {
                CreateMap<GetProfessorByIdQuery, Professor>();
                CreateMap<Professor, GetProfessorByIdQuery>();
            }
        }
    }
}
