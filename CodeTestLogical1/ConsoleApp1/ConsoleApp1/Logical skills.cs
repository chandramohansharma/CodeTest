// See https://aka.ms/new-console-template for more information

int count = 100;

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("fizz" + i.ToString());
    }
    if (i % 5 == 0)
    {
        Console.WriteLine("buzz" + i.ToString());
    }
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz" + i.ToString());
    }
}
Console.ReadLine();
