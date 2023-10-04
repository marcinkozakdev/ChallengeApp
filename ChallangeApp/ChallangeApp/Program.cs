using ChallangeApp;

var employee1 = new Employee("Jan", "Kowalski", 29);
var employee2 = new Employee("Adam", "Lewandowski", 35);
var employee3 = new Employee("Marek", "Nowak", 50);

employee1.AddScore(6);
employee1.AddScore(6);
employee1.AddScore(6);
employee1.AddScore(6);
employee1.AddScore(6);

employee2.AddScore(7);
employee2.AddScore(7);
employee2.AddScore(7);
employee2.AddScore(7);
employee2.AddScore(7);

employee3.AddScore(8);
employee3.AddScore(8);
employee3.AddScore(8);
employee3.AddScore(8);
employee3.AddScore(8);

if(employee1.Result > employee2.Result && employee2.Result > employee3.Result)
{
    employee2.Print();
}
else if(employee2.Result > employee3.Result)
{
    employee2.Print();
}
else
{
    employee3.Print();
}
