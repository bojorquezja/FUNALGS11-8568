Console.WriteLine("ingrese la cantidad de elementos = ");
int r = int.Parse(Console.ReadLine());
int[] valor = new int[r];
Random ra = new Random();
int c = 0, c1 = 0, total = 0, total1 = 0;
for (int i = 0; i < valor.Length; i++)
{
    total = valor[i] = ra.Next(50, 90);
    
}
Console.Write("¿Te gustan los pares o impares? = ");
string h = Console.ReadLine();
if (h == "pares")
{
    if (total % 2 == 0)
    {
        c++;
    }
    
}
Console.WriteLine("valores pares = " + total);


