using ExtensionMethod;

int[] ints = [6, 2, 14, 8, 39, 0];
double[] doubles = [1.324, 3.312, 4, 6.7];
Person[] people = [new Person("John Doe", 35), new Person("Kiss Pista", 23), new Person("Pici Peti", 19)];

#region Sum
Console.WriteLine(ints.MySum());

Console.WriteLine(doubles.MySum());

Console.WriteLine(people.MySum(x => x.Age));
#endregion

#region Where
Console.WriteLine(string.Join(", ", people.MyWhere(x => x.Age < 25)));
#endregion

#region OrderBy
Console.WriteLine(string.Join(", ", ints.MyOrderBy()));

Console.WriteLine(string.Join(", ", people.MyOrderBy(x => x.Age)));
#endregion
