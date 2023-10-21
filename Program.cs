//Задайте значение N. 
//Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);

void NaturalToLow(int N, int count)
{
    if (count > N)
    {
        return;
    }
    else
    {
        NaturalToLow(N, count + 1);
        Console.Write(count + " ");
    }
}

