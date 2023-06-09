Console.WriteLine("Enter a number:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Even numbers from 1 to N:");
while (i <= N)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
    i += 1;
}