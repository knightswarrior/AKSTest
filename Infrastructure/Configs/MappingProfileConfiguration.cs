using AutoMapper;
using TMLS.APIFramework.DTO;
using TMLS.APIFramework.DTO.Response;
using TMLS.APIFramework.DTO.Request;
using TMLS.API.Model;

namespace TMLS.APIFramework.Infrastructure.Configs
{
    public class MappingProfileConfiguration: Profile
    {
        public MappingProfileConfiguration()
        {
            CreateMap<Person, CreatePersonRequest>().ReverseMap();
            CreateMap<Person, UpdatePersonRequest>().ReverseMap();
            CreateMap<Person, PersonQueryResponse>().ReverseMap();
        }
    }
}
