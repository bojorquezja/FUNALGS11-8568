// See https://aka.ms/new-console-template for more information
Random random = new Random();
Console.Write("ingresar cantidad de numeros aleatorios");
int cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("¿quieres numeros imapres o impares? (ingresar 'p' o 'i') ");
string tipo = Console.ReadLine().ToLower();
Console.WriteLine("los numeros son: ");
int contador = 0;

while (contador < cantidad)
{
    int numero = random.Next(50, 90);
    if (tipo == "p" && numero % 2 == 0)
    {
        Console.WriteLine("los numeros aleatorios pares son: " + numero);
        contador++;
    }
    if (tipo == "i" && numero % 2 != 0)
    {
        Console.WriteLine("los numeros impares son: " + numero);
        contador ++;
    }
}