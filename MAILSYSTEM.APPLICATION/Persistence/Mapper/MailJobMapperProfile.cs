using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.Mapper;

public class MailJobMapperProfile : Profile
{
    public MailJobMapperProfile()
    {
        CreateMap<MailJobRequest, MailJob>();

        CreateMap<State, StateResponse>().ReverseMap();

        CreateMap<List<State>, AllStateResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new StateResponse()
                    {
                        Id = t.Id,
                        StateAbbreviation = t.StateAbbreviation,
                        StateDescription = t.StateDescription
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
