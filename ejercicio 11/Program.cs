using System.ComponentModel.Design;

Console.WriteLine("ingrese la cantidad de elementos de arreglo: ");
int r = int.Parse(Console.ReadLine());
int[] valor = new int[r];
Random ra = new Random();
int p = 0, im = 0;
for (int i = 0; i < valor.Length; i++)
{

     valor[i] = ra.Next(50, 90);
    if (valor[i] % 2 == 0)
    {
        p++;
    }
    else
    {
        im++;
    }



}
Console.Write("\n¿te gustan los impares?=");
string h = Console.ReadLine();
if (h == "pares")
{
    Console.WriteLine("\n los numeros pares son = " + p);
}
else if (h=="impares")
{
    Console.WriteLine("\n los numeros impares son = " + im);
}
