Console.Clear();

int num = new Random().Next(100,1000);
int a1 = num / 100;
int a3 = num % 10;
int result = a1*10+a3;

Console.WriteLine($"{num} -> {result}");