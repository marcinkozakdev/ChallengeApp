﻿//Zadanie domowe - dzień 4

string name = "Ewa";
char sex = 'K';
int age = 29;

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

else if (sex == 'M' && age < 18 )
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}