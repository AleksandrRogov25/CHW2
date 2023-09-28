System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number >= 1000)
{
System.Console.WriteLine("Вы ввели не трехзначное число, повторите попытку");
return;
}
System.Console.WriteLine($"Вы ввели: {number}");
int secondNumber = number / 10 % 10;
System.Console.WriteLine($"Вторая цифра: {secondNumber}");
