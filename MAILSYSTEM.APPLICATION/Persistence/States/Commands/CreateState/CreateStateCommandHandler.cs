using MAILSYSTEM.DOMAIN.Abstractions;
using MAILSYSTEM.DOMAIN.Errors;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Commands.CreateState;

internal sealed class CreateStateCommandHandler : ICommandHandler<CreateStateCommand, string>
{
    private readonly IStateRepository _stateRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateStateCommandHandler(IStateRepository stateRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _stateRepository = stateRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<string>> Handle(CreateStateCommand request, CancellationToken cancellationToken)
    {
        if (!await _stateRepository.IsNameUniqueAsync(request.item.stateDescription, cancellationToken))
        {
            return Result.Failure<string>(DomainErrors.State.StateNameInUse);
        }

        if (!await _stateRepository.IsAbbreviationUniqueAsync(request.item.stateAbbreviation, cancellationToken))
        {
            return Result.Failure<string>(DomainErrors.State.StateAbbreviationInUse);
        }

        var newItem = _mapper.Map<State>(request.item);

        _stateRepository.Add(newItem);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return newItem.Id.ToString();
    }
}
