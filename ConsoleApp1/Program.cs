// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name = "Robert";
Console.WriteLine(name);
Console.WriteLine($"Hello, {name}");

static double calculateAverage (int[] tab)
{
    if(tab == null || tab.Length == 0) return 0;
    int sum = 0;
    foreach( int i in tab )
    {
        sum += i;
    }

    return sum / tab.Length;
}

double tmp = calculateAverage(new int[]{2, 5, 7, 3, 4, 1, 7});
Console.WriteLine(tmp);