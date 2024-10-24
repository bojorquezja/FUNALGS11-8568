Console.Write("ingrese la cantidad de elementos = ");
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
Console.Write("\n¿Te gustan los pares o impares? = ");
string h = Console.ReadLine();
if (h == "pares")
{
    Console.WriteLine("\nLos numeros pares son = " + p);
    
}
else if (h == "impares")
{
    Console.WriteLine("\nLos numeros impares son = " + im);
}

Console.Write("el mas duro de la nueva ");



