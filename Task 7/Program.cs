Console.Clear();
Console.Write("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int last = num % 10;

Console.WriteLine($"{last}");