Console.Clear();
Console.WriteLine("Введите первое число  ");
string userInput1 = Console.ReadLine() ??"";
int number1 = int.Parse(userInput1);

Console.WriteLine("Введите второе число  ");
string userInput2 = Console.ReadLine()??"";
int number2 = int.Parse(userInput2);

int remains = number1%number2;

if (remains==0)
{    
    Console.WriteLine ($"Кратное ");
}
else
{
    Console.WriteLine ($"{number1} Не кратно {number2} -> Остаток:{remains} ");
}