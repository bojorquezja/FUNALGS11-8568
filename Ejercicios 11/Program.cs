Console.WriteLine("ingrese la cantidad de elementos = ");
int r = int.Parse(Console.ReadLine());
int[] valor = new int[r];
Random ra = new Random();
int c = 0, c1 = 0, total = 0, total1 = 0, p = 0, im = 0;
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
Console.Write("¿Te gustan los pares o impares? = ");
string h = Console.ReadLine();
if (h == "pares")
{
    Console.WriteLine("pares = " + p);
    
}
if (h == "impares")
{
    Console.WriteLine("impares = " + im);
}



