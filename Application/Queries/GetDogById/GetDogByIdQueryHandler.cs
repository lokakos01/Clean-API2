using MediatR;
using Domain.Models;
using Infrastruction.Database;

namespace Application.Queries.GetDogById
{
    internal class GetDogByIdQueryHandler : IRequestHandler<GetDogByIdQuery, Dog>
    {
        private readonly MockDatabase _mockDatabase;

        public GetDogByIdQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }     
             
        public Task<Dog> Handle(GetDogByIdQuery request, CancellationToken cancellationToken)
        {
            Dog wantedDog = _mockDatabase.allDogs.Where(Dog => Dog.AnimalId == request.Id).FirstOrDefault();
            return Task.FromResult(wantedDog);
        }
    }
}
