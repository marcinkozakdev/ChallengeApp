int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] caunters = new int[10];
char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

Console.WriteLine("Wyniki dla liczby: " + number);

foreach (char letter in letters)
{
    for (int i = 0; i < caunters.Length; i++)
    {
        if (letter == numbers[i])
        {
            caunters[i]++;
        }
    }
}

for (int i = 0; i < caunters.Length; i++)
{
    Console.WriteLine(numbers[i] + " => " + caunters[i]);
}