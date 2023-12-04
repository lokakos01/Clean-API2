using Domain.Models;

namespace Infrastruction.Database
{       
    public class MockDatabase
    {
        public List<Dog> allDogs
        {
            get { return AllDogsFromMockDatabase; }
            set { AllDogsFromMockDatabase = value; }

        }

        private static List<Dog> AllDogsFromMockDatabase = new()
        {
            new Dog
            {
                AnimalId = Guid.NewGuid(), Name = "Dragan"
            }, new Dog
            {
                AnimalId = Guid.NewGuid(), Name = "Zlatan"
            }, new Dog
            {
                AnimalId = Guid.NewGuid(), Name = "Ibra"
            }, new Dog
            {
                AnimalId = Guid.NewGuid(), Name = "Kalle"
            },
        };

        public List<Cat> allCats
        {
            get { return AllCatsFromMockDatabase; }
            set { AllCatsFromMockDatabase = value; }

        }

        private static List<Dog> AllDogsFromMockDatabase = new()
        {
            new Dog
            {
                AnimalId = Guid.NewGuid(), Name = "Dragan"
            }, new Dog
            {
                AnimalId = Guid.NewGuid(), Name = "Zlatan"
            }, new Dog
            {
                AnimalId = Guid.NewGuid(), Name = "Ibra"
            }, new Dog
            {
                AnimalId = Guid.NewGuid(), Name = "Kalle"
            },
        };
    }
}
