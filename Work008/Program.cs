//программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом
int number = -1;
string userInput = String.Empty;
while (true)
{
    Console.WriteLine("Введите любое натуральное  число: ");
    
     userInput = Console.ReadLine();
    if (userInput == "exit") break;
    
        else
    {    
        number = Convert.ToInt32(userInput);
        
        if (number < 0) Console.WriteLine("Программа работает только с натуральными числами. Введите натуральное число либо команду exit");
        else
        {
            
            int forDecCount = number;

            
            int mirrowedNumber = 0;

            
            int dec = 10;
                      
            
            while (forDecCount > 0) 
            {
                    
                mirrowedNumber = mirrowedNumber*dec + forDecCount%dec;
                
                forDecCount = forDecCount/dec;
            }

            
            

            if (number == mirrowedNumber) Console.WriteLine($"{number} -> да");
            else Console.WriteLine($"{number} -> нет");
            break;
        }
    }
}