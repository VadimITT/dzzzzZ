Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(a);
if (number.Length == 2) 
{
    Console.WriteLine("Третья цифра " + number[2]);
}

else
{
    Console.WriteLine("Вы ввели не трёхзначное число ");
}

