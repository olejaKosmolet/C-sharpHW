// Task 4

Console.Write("Введите число №1: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число №2: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число №3: ");
double thirdNumber = Convert.ToDouble(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine($"Наибольшим числом является {firstNumber}");    
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine($"Наибольшим числом является {secondNumber}");
}
else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    Console.WriteLine($"Наибольшим числом является {thirdNumber}");
}
