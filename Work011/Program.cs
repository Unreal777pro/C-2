//программа принимает на вход числа А и В и возводит А в натуральную степень В


int number = InputInt("Введите число: ");
int powInt = InputInt("Введите степень в виде натурального числа: ");

if (powInt < 0) Console.WriteLine("Степень должна быть натуральным числом");
else Console.WriteLine($"{number},{powInt} -> {Pow(number,powInt)}");

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}


double Pow(double number, int powNumber)
{
   int count = 1;
   double pow = 1;    
   while (count <= powNumber)
   {
       pow*=number;
       count++;
   }
   return pow;
}

