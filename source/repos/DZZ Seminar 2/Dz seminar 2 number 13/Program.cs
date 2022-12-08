Console.WriteLine("Введите цифру обозночающую день недели, а программа покажет являеться ли этот день выходным ");
int a = Convert .ToInt32(Console.ReadLine());
if (a <= 7) 
{
 if (a<=5)
    {
        Console.WriteLine("День " + a + " это рабочий день");
    }
 
 else
    {
        Console.WriteLine("День " + a + " Это выходной день");
    }
}
else
{
    Console.WriteLine("Вы ввели цифру не соответствующую ни одному дню недели");
}