namespace DeconstructionLib
{
    public class School
    {
        private readonly List<Student> _students = [];

        public IEnumerable<Student> Students => _students;

        public void AddStudent(Student student) => _students.Add(student);

        public string PrintAllStudents => PrintStudents(Students);

        public string PrintStudentsWithAVG(double average) => PrintStudents(Students.Where(x => x.Average > average));

        public static string PrintStudents(IEnumerable<Student> students) => string.Join('\n', students
            .Select(student =>
            {
                (string Name, DateOnly BirthDate, string Class, double Average) = student;

                return $"{Name} ({BirthDate}) {Class}: {Average:N2}";
            }));
    }
}
