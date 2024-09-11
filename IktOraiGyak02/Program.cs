

if (args.Length > 1 && args.Length % 2 == 1)
{
    foreach (var arg in args)
    {
        Console.WriteLine(arg);
    }
}
else
{
    Console.WriteLine("Nem megfelelő argumentumszám!");
}