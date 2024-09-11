

if (args.Length > 1 && args.Length % 2 == 1)
{

    int before = int.Parse(args[args.Length % 2 - 1]);
    int middle = int.Parse(args[args.Length % 2]);
    int after = int.Parse(args[args.Length % 2 + 1]);

    int pow = before > after ? before / after : after / before;

    Console.WriteLine($"Eredmény: {Math.Pow(middle, pow)}");
}
else
{
    Console.WriteLine("Nem megfelelő argumentumszám!");
}

Console.WriteLine("---------------------------------");


List<int> list = new List<int>();
int moreThanFour = 0;

foreach (var item in File.ReadAllLines("szavak.txt"))
{
    int i, vowels;

    vowels = 0;

    for (i = 0; i < item.Length; i++)
    {

        if (item[i] == 'a' || item[i] == 'e' ||
            item[i] == 'i' || item[i] == 'o' ||
            item[i] == 'u' || item[i] == 'A' ||
            item[i] == 'E' || item[i] == 'I' ||
            item[i] == 'O' || item[i] == 'U')
        {
            vowels++;
        }
    }
    if (vowels > 4)
    {
        moreThanFour++;
    }
    list.Add(vowels);
}

Console.WriteLine($"A több, mint négy szótagból álló szavak száma: {moreThanFour}");
Console.WriteLine($"A legnagyobb szótagszám: {list.Max()}");


Console.WriteLine("---------------------------------");

Random rnd = new Random(33);

int[,] matrix = new int[6, 6];

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        matrix[i, j] = rnd.Next(55, 156);
    }
}

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}


int edgeSum = 0;
int edgeCount = 0;

for (int i = 0; i < 6; i++)
{
    edgeSum += matrix[0, i];
    edgeSum += matrix[5, i]; 
    edgeCount += 2;
}

for (int i = 1; i < 5; i++)
{
    edgeSum += matrix[i, 0];
    edgeSum += matrix[i, 5];
    edgeCount += 2;
}

double edgeAverage = (double)edgeSum / edgeCount;

Console.WriteLine($"A szélső elemek átlaga: {edgeAverage:F2}");

Console.WriteLine("---------------------------------");

string[] lines = File.ReadAllLines("kep.txt");
string[] modifiedLines = new string[lines.Length];

for (int i = 0; i < lines.Length; i++)
{
    string[] rgb = lines[i].Split(';');
    int r = int.Parse(rgb[0]);
    int g = int.Parse(rgb[1]);
    int b = int.Parse(rgb[2]);

    if (b < 100)
    {
        b += 20;
    }

    modifiedLines[i] = $"{r};{g};{b}";
}

File.WriteAllLines("kekitett.txt", modifiedLines);

Console.WriteLine("#Kész!");
