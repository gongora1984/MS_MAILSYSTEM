using MAILSYSTEM.DOMAIN.Contracts.Requests;
using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Mapper;

public class ListItemMappingProfile : Profile
{
    public ListItemMappingProfile()
    {
        CreateMap<RegisterListItemRequest, ListItem>();

        CreateMap<ListItem, ListItemResponse>().ReverseMap();

        CreateMap<List<ListItem>, AllListItemResponse>()
            .ForMember(
                dest => dest.Items,
                src => src.MapFrom(s => s.Select(
                    t => new ListItemResponse()
                    {
                        Id = t.Id,
                        SystemCategory = t.SystemCategory,
                        SystemTag = t.SystemTag,
                        ListItemDisplayText = t.ListItemDisplayText,
                        ListItemOrder = t.ListItemOrder,
                        ListItemEnable = t.ListItemEnable
                    }).ToList()))
            .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count));
    }
}
