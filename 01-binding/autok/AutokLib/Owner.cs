using System.Globalization;

namespace AutokLib
{
    public record Owner
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public DateOnly? TimeOfObtainingDriversLicense { get; init; }
        public string Modell { get; init; }

        public Owner(string line)
        {
            string[] parts = line.Split(';');

            Id = int.Parse(parts[0]);
            Name = parts[1];
            TimeOfObtainingDriversLicense =
                parts[2] == "Van"
                ? DateOnly.Parse(parts[3], new CultureInfo("hu-HU"))
                : null;
            Modell = parts[4];
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
            .FirstOrDefault(x => x.Modell == Modell);

        public override string ToString() =>
            $"{Name} ({Car?.Make} - {Car?.Modell}), {OwnerData?.Sex}, {OwnerData?.BirthYear}";
    }
}
