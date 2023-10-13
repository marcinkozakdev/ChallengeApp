using ChallangeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade("2");
employee.AddGrade(2);
employee.AddGrade(6);
var statisctics = employee.GetStatistics();
var statisctics1 = employee.GetStatisticsWithForEach();
var statisctics2 = employee.GetStatisticsWithFor();
var statisctics3 = employee.GetStatisticsWithDoWhile();
var statisctics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("Wyniki dla pętli foreach:");
Console.WriteLine($"Average: {statisctics1.Average:N2}");
Console.WriteLine($"Min: {statisctics1.Min}");
Console.WriteLine($"Max: {statisctics1.Max}");
Console.WriteLine();

Console.WriteLine("Wyniki dla pętli for:");
Console.WriteLine($"Average: {statisctics2.Average:N2}");
Console.WriteLine($"Min: {statisctics2.Min}");
Console.WriteLine($"Max: {statisctics2.Max}");
Console.WriteLine();

Console.WriteLine("Wyniki dla pętli do while:");
Console.WriteLine($"Average: {statisctics3.Average:N2}");
Console.WriteLine($"Min: {statisctics3.Min}");
Console.WriteLine($"Max: {statisctics3.Max}");
Console.WriteLine();

Console.WriteLine("Wyniki dla pętli while:");
Console.WriteLine($"Average: {statisctics4.Average:N2}");
Console.WriteLine($"Min: {statisctics4.Min}");
Console.WriteLine($"Max: {statisctics4.Max}");
Console.WriteLine();
