Console.WriteLine("Введите число) ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввкдите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max<b)
{
    max = b;
}
if (max<c)
{
    max = c;
}
Console.WriteLine("Наибольшее число = " + max);
