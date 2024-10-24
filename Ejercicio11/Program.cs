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