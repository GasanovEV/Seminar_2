Console.Clear();
Console.WriteLine("Введите число  ");
string userInput1 = Console.ReadLine() ??"";
int number1 = int.Parse(userInput1);


if (number1%7==0 && number1%23==0)
{    
    Console.WriteLine ($"{number1} -> кратно 7 и 23 ");
}
else
{
    Console.WriteLine ($"{number1} -> не кратно 7 и 23 ");
}
