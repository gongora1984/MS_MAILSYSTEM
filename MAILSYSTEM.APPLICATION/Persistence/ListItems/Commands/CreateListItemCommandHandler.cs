using MAILSYSTEM.DOMAIN.Abstractions;
using MAILSYSTEM.DOMAIN.Errors;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Commands;

internal sealed class CreateListItemCommandHandler : ICommandHandler<CreateListItemCommand, string>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateListItemCommandHandler(IListItemRepository listItemRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<string>> Handle(CreateListItemCommand request, CancellationToken cancellationToken)
    {
        if (!await _listItemRepository.IsSystemItemUniqueAsync(request.item.systemCategory, request.item.systemTag, request.item.listItemDisplayText, cancellationToken))
        {
            return Result.Failure<string>(DomainErrors.ListItem.SystemCategoryTagDisplayInUse);
        }

        var newItem = _mapper.Map<ListItem>(request.item);

        _listItemRepository.Add(newItem);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return newItem.Id.ToString();
    }
}
