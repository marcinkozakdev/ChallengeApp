using ChallangeApp;

Console.WriteLine("Welcome to Employee Evaluation Program");
Console.WriteLine("==============================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Input next grade of Your Employee: ");
    Console.WriteLine("... if you want to see the statistics press 'q'");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

Console.WriteLine();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Employee evaluation statistics:");
Console.WriteLine("----------------------------------------------");

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");