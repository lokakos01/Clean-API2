using MediatR;
using Domain.Models;
using Infrastruction.Database;

namespace Application.Queries.Dogs
{
    internal class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly MockDatabase _mockDatabase;

        public GetAllDogsQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }
        public Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Dog> AllDogsfromMockDB = _mockDatabase.allDogs;
            return Task.FromResult(AllDogsfromMockDB);        
        }
    }
}
