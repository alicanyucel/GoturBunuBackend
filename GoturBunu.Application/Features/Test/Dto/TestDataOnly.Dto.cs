using AutoMapper;

namespace GoturBunu.Application.Features.Test
{
    public class TestDataOnlyDto
    {
        public int Data { get; set; }
    }

    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.Test, TestDataOnlyDto>();
        }
    }
}
