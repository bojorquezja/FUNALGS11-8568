// See https://aka.ms/new-console-template for more information

int c = 0;
Random r = new Random();

Console.Write("Ingrese cantidad de elementos: ");
int n = int.Parse(Console.ReadLine());

Console.Write("¿Prefiere los números pares (P) o impares (I)?: ");
string v = Console.ReadLine().ToUpper();
Console.WriteLine();

while (c < n)
{
    
    int numero = r.Next(50, 89 + 1);

    if (v == "P" && numero % 2 == 0)
    {
        Console.Write($"{ numero} ");
        c++;
    }
    else if (v == "I" && numero % 2 != 0)
    {
        Console.WriteLine($"{numero} ");
        c++;
    }
}
Console.WriteLine();
if (v == "P")
{
    Console.WriteLine("Cantidad de pares: " + c);
}
else if (v == "I")
{
    Console.WriteLine("Cantidad de impares: " + c);
}
