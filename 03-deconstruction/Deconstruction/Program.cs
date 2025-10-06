using DeconstructionLib;

var school = new School();

new List<Student> {
    new("Jonh Doe", new DateOnly(2000, 1, 1), "32.zs", 4.59),
    new("Jane Doe", new DateOnly(1998, 12, 31), "12.d", 3.29),
    new("Kis Pista", new DateOnly(2009, 10, 5), "10.c", 2),
    new("Hatalmas János", new DateOnly(2005, 06, 17), "13.b", 4.3),
}.ForEach(school.AddStudent);

Console.WriteLine(school.PrintAllStudents);

Console.Write("\nAdjon meg egy minimum átlagot: ");
double minAvg = double.Parse(Console.ReadLine() ?? string.Empty);
Console.WriteLine(school.PrintStudentsWithAVG(minAvg));
