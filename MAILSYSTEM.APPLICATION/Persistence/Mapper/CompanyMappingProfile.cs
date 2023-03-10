using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Mapper;

public class CompanyMappingProfile : Profile
{
    public CompanyMappingProfile()
    {
        CreateMap<RegisterCompanyRequest, Company>()
            .ForMember(dest => dest.CompanyState, opt => opt.MapFrom(src => new Guid(src.companyState)))
            .ForMember(dest => dest.CompanyBillingState, opt => opt.MapFrom(src => new Guid(src.companyBillingState)))
            .ForMember(dest => dest.CompanyReturnState, opt => opt.MapFrom(src => string.IsNullOrEmpty(src.companyReturnState) ? (Guid?)null : new Guid(src.companyReturnState)));

        CreateMap<Company, RegisterCompanyRequest>()
            .ForMember(dest => dest.companyState, opt => opt.MapFrom(src => src.CompanyState.ToString()))
            .ForMember(dest => dest.companyBillingState, opt => opt.MapFrom(src => src.CompanyBillingState.ToString()))
            .ForMember(dest => dest.companyReturnState, opt => opt.MapFrom(src => src.CompanyReturnState == null ? string.Empty : src.CompanyReturnState.ToString()));

        CreateMap<Company, CompanyResponse>().ReverseMap();

        CreateMap<Company, AllCompaniesResponse>().ReverseMap();

        CreateMap<List<Company>, AllCompaniesResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new CompanyResponse()
                    {
                        Id = t.Id,
                        CompanyName = t.CompanyName,
                        CompanyUsername = t.CompanyUsername,
                        CompanyPassword = t.CompanyPassword,
                        CompanyAddress1 = t.CompanyAddress1,
                        CompanyAddress2 = t.CompanyAddress2,
                        CompanyCity = t.CompanyCity,
                        CompanyState = t.CompanyState,
                        CompanyZip = t.CompanyZip,
                        CompanyPhone = t.CompanyPhone,
                        CompanyFax = t.CompanyFax,
                        CompanyEmail = t.CompanyEmail,
                        CompanyBillingAddress1 = t.CompanyBillingAddress1,
                        CompanyBillingAddress2 = t.CompanyBillingAddress2,
                        CompanyBillingCity = t.CompanyBillingCity,
                        CompanyBillingState = t.CompanyBillingState,
                        CompanyBillingZip = t.CompanyBillingZip,
                        CompanyReturnName = t.CompanyReturnName,
                        CompanyReturnAddress1 = t.CompanyReturnAddress1,
                        CompanyReturnAddress2 = t.CompanyReturnAddress2,
                        CompanyReturnCity = t.CompanyReturnCity,
                        CompanyReturnState = t.CompanyReturnState,
                        CompanyReturnZip = t.CompanyReturnZip,
                        CompanyReturnEmailAddress = t.CompanyReturnEmailAddress,
                        CompanyDefaultFilePathLocation = t.CompanyDefaultFilePathLocation
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
