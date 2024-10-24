// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

int ci = 0, cp = 0, x;

Console.Write("Ingrese cantidad de elementos: ");
int n = int.Parse(Console.ReadLine());
Console.Write("¿Prefiere los números pares (P) o impares (I)?: ");
string v = Console.ReadLine().ToUpper();
Console.WriteLine();

int[] numeros = new int[n];
Random ran = new Random();

for (x = 0; x < n; x++)
{
    numeros[x] = ran.Next(50, 89 + 1);

    if (numeros[x] % 2 == 0)
    {
        cp++;
    }
    else if (numeros[x] % 2 != 0)
    {
        ci++;
    }      
}

string todos = String.Join(", ", numeros);
Console.WriteLine($"Números: {todos}");
Console.WriteLine();
if (v == "P")
{
    Console.WriteLine("Cantidad de pares: " + cp);
}
else if (v == "I")
{
    Console.WriteLine("Cantidad de impares: " + ci);
}