using AutoMapper;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Mapper;

public static class CompanyMapper
{
    private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
            cfg.AddProfile<CompanyMappingProfile>();
        });

        var mapper = config.CreateMapper();

        return mapper;
    });

    public static IMapper Mapper => Lazy.Value;
}
