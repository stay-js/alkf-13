namespace VedettAllatokLib
{
    public class AnimalStore
    {
        private readonly List<Animal> _animals = File
            .ReadAllLines("Input/vedett.csv")
            .Skip(1)
            .Select(Animal.FromCSV)
            .ToList();

        public IEnumerable<Animal> GetAll() => _animals;

        public IEnumerable<string> GetCategories() => _animals
            .Select(x => x.Category)
            .Distinct();

        public Animal? GetById(int id) => _animals
            .FirstOrDefault(animal => animal.Id == id);

        public IEnumerable<Animal> GetByYear(int year) => _animals
            .Where(animal => animal.Year == year);

        public IEnumerable<Animal> GetByCategory(string category) => _animals
            .Where(animal => animal.Category == category);

        public void AddNew(AnimalData animal)
        {
            int id = _animals.Select(x => x.Id).Max() + 1;
            _animals.Add(Animal.FromAnimalData(id, animal));
        }

        public bool Update(int id, AnimalData animal)
        {
            int index = _animals.FindIndex(x => x.Id == id);

            if (index != -1)
            {
                _animals[index] = Animal.FromAnimalData(id, animal);
                return true;
            }

            return false;
        }

        public void Delete(int id) => _animals.RemoveAll(x => x.Id == id);
    }
}
