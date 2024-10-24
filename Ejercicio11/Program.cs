int n = 0;
string preferencia = "";
int conteoPares = 0, conteoImpares = 0;

Console.WriteLine("Ingrese la cantidad de elementos del arreglo:");
n = int.Parse(Console.ReadLine());

int[] arreglo = new int[n];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    arreglo[i] = random.Next(50, 91);
}
Console.WriteLine("¿Prefiere números pares o impares? (escriba 'pares' o 'impares'):");
preferencia = Console.ReadLine().ToLower();

Console.WriteLine("Elementos del arreglo:");
foreach (int numero in arreglo)
{
    Console.Write(numero + " ");
    if (numero % 2 == 0)
        conteoPares++;
    else
        conteoImpares++;
}
Console.WriteLine();
if (preferencia == "pares")
{
    Console.WriteLine($"Hay {conteoPares} números pares en el arreglo.");
}
else if (preferencia == "impares")
{
    Console.WriteLine($"Hay {conteoImpares} números impares en el arreglo.");
}