Console.WriteLine("Введите число   ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA >=100 && numberA <1000)
{
int X = numberA % 10;
Console.WriteLine("Третья цифра числа является  "+ X);
}
else
Console.WriteLine("Третьей цифры нет");