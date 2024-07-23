void Main()
{
    int n = 0;
    do
    {
        n++;
        if (n % 15 == 0)
        {
            Console.WriteLine("fizzbuzz");
        }
        else if (n % 3 == 0)
        {
            Console.WriteLine("fizz");
        }
        else if (n % 5 == 0)
        {
            Console.WriteLine("buzz");
        }
        else
        {
            Console.WriteLine(n);
        }
        ;
    } while (n < 100);
}

Main();
