using System.Globalization;

namespace AutokLib
{
    public record Owner
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public DateOnly? TimeOfObtainingDriversLicense { get; init; }
        public string Model { get; init; }

        public Owner(string line)
        {
            string[] parts = line.Split(';');

            Id = int.Parse(parts[0]);
            Name = parts[1];
            TimeOfObtainingDriversLicense =
                parts[2] == "Van"
                ? DateOnly.Parse(parts[3], new CultureInfo("hu-HU"))
                : null;
            Model = parts[4];
        }

        public bool HasDriversLicense => TimeOfObtainingDriversLicense is not null;
        public int? YearsSinceLicenceObtained => HasDriversLicense
            ? DateTime.Now.Year - TimeOfObtainingDriversLicense?.Year
            : null;

        public OwnerData? OwnerData => DataStore
            .Instance?
            .OwnerData
            .FirstOrDefault(x => x.OwnerId == Id);

        public Car? Car => DataStore
            .Instance?
            .Cars
            .FirstOrDefault(x => x.Model == Model);

        public override string ToString() =>
            $"{Name} ({Car?.Make} - {Car?.Model}), {OwnerData?.Sex}, {OwnerData?.BirthYear}";
    }
}
