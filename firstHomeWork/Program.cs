// Task 2

Console.Write("Введите 1-ое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Число {firstNumber} больше!\nЧисло {secondNumber} меньше!");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"Число {secondNumber} больше!\nЧисло {firstNumber} меньше!");
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine($"Число {secondNumber} равно числу {firstNumber}!");
}
