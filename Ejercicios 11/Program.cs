/*Console.Write("ingrese la cantidad de elementos = ");
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
Console.Write("roro ");/*

/*Console.Write("ingre numero n = ");
int n = int.Parse(Console.ReadLine());
int[] num = new int[n];
Random ale = new Random();
for (int i = 0; i < n; i++)
{
    num[i] = ale.Next(0, 51);
}*/

/*
int[] cambio = { 4, 8, 10, 25 };

Console.WriteLine("Lista original: ");
foreach (int r in cambio)
{
    Console.WriteLine(r);
}

Console.WriteLine("Lista modificacion: ");

cambio[2] = 36;
foreach (int r in cambio)
{
    Console.WriteLine(r);
}*/

/*
string[] valor = { "jose", "oscar", "carmen", "alexa" };

Console.Write("ingrese un nombre buscar = ");
string f = Console.ReadLine();

int indice = Array.IndexOf(valor, f);
if(indice != -1)
{
    Console.WriteLine($"esta en la posicion = {indice}");
}
else
{
    Console.WriteLine("no existe");
}*/
/*
char[] nom = { 'a', 'e', 'i', 'o', 'u' };

Console.Write("lista original = ");
foreach (char c in nom)
{
    Console.WriteLine(c);
}

Console.Write("ingrese el caracter a modificar: ");
char modificar = char.Parse(Console.ReadLine());

int indice = Array.IndexOf(nom, modificar);

if (indice != -1)
{
    Console.Write("ingrese su nuevo valor: ");
    char nuevo = char.Parse(Console.ReadLine());
    Console.Write("lista modificada");
    nom[indice] = nuevo; // asigancion;
    foreach (char c in nom)
    {
        Console.WriteLine(c);
    }
}
else
{
    Console.WriteLine("falso");
        
 }*/


int[] num = new int[0];
int posicion = 0;
int datos;
char opcion;

Console.Write("ingresar numero = ");
do
{


    while (!int.TryParse(Console.ReadLine(), out datos))
    {
        Console.Write("error : ingrese numero: ");
    }
    Array.Resize(ref num, num.Length + 1);
    num[posicion] = datos;
    posicion++;



    do
    {
        Console.WriteLine("\nDesea seguir registrandose s/n");
        opcion = char.ToLower(Console.ReadKey().KeyChar);

    } while (opcion != 's' & opcion != 'n');
} while (opcion == 's');
Console.WriteLine("lista de numeros");
foreach (int i in num)
{
    Console.WriteLine(i);
}















