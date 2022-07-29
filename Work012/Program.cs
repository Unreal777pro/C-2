//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int tempNumber = number;
int sum = 0;


while (tempNumber > 1)
{
    sum+=tempNumber%10;
    tempNumber/=10;    
}

Console.WriteLine(number +"->" + sum);