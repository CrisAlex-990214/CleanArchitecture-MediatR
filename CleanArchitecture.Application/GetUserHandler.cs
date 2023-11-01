using CleanArchitecture.Application.Dtos;
using CleanArchitecture.Application.Interfaces;
using MediatR;

namespace CleanArchitecture.Application
{
    public class GetUserRequest : IRequest<UserDto>
    {
        public int Id { get; set; }
    }

    public class GetUserHandler : IRequestHandler<GetUserRequest, UserDto>
    {
        private readonly IDatabaseService databaseService;

        public GetUserHandler(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public Task<UserDto> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var user = databaseService.GetUser(request.Id);
            var userDto = new UserDto { Id = user.Id, Name = user.Name };

            return Task.FromResult(userDto);
        }
    }
}
