using ChallangeApp;
var employee = new Employee("Jan", "Kowalski", 29);

employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);

var statisctics = employee.GetStatistics();
Console.WriteLine($"Average: {statisctics.Average:N2}");
Console.WriteLine($"Min: {statisctics.Min}");
Console.WriteLine($"Max: {statisctics.Max}");