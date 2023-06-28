Console.WriteLine("inserire 10 volte dei numeri:");
int[] ArrayNumbers = new int[10];
int i = 0;

while (i < ArrayNumbers.Length)
{
    ArrayNumbers[i] = int.Parse(Console.ReadLine());
    i++;
}

Console.WriteLine("------------------------------------------");
Console.WriteLine("sto stampando l'elenco:");

foreach (int number in ArrayNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("------------------------------------------");
Console.WriteLine("sto stampando l'elenco al contrario:");

Array.Reverse(ArrayNumbers);
foreach(int number in ArrayNumbers)
{
    Console.WriteLine(number);
}






