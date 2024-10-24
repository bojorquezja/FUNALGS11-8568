// See https://aka.ms/new-console-template for more information

int c = 0, x = 0;

Console.Write("Ingrese cantidad de elementos: ");
int n = int.Parse(Console.ReadLine());

int[] numeros = new int[n];
Random ran = new Random();

for (x = 0; x < n; x++)
{
    numeros[x] = ran.Next(10, 99 + 1);
}

if (x % 2 == 0)
{
    c =+ 0;
}
else if (x % 2 != 0)
{
    c =+ 0;
}

string todos = String.Join(", ", numeros);
Console.WriteLine($"Números: {todos}");

Console.Write("¿Prefiere los números pares (P) o impares (I)?: ");
string v = Console.ReadLine().ToUpper();
Console.WriteLine();

if (v == "P")
{
    Console.WriteLine("Cantidad de pares: " + c);
}
else if (v == "I")
{
    Console.WriteLine("Cantidad de impares: " + c);
}
