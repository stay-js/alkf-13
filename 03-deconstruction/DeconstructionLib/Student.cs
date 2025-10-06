namespace DeconstructionLib
{
    public class Student(string name, DateOnly birthDate, string studentClass, double average)
    {
        public string Name { get; init; } = name;
        public DateOnly BirthDate { get; init;} = birthDate;
        public string Class { get; init; } = studentClass;
        public double Average { get; init; } = average;

        public void Deconstruct(out string Name, out DateOnly BirthDate, out string Class, out double Average)
        {
            Name = this.Name;
            BirthDate = this.BirthDate;
            Class = this.Class;
            Average = this.Average;
        }
    }
}
