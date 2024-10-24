namespace ejercicio11
{
    class LL
    {
        static void Main(string[] args)
        {
            int impar = 0, par = 0;
            Console.WriteLine("Ingrese cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];
            Random ran = new Random();
            int sum = 0;
            for (int x = 0; x < n; x++)
            {
                numeros[x] = ran.Next(50, 90 + 1);
                if (numeros[x] % 2 == 0)
                {
                    par++;
                }
                else { impar++; }
            }
            int sl = 0;
            string todos = String.Join(", ", numeros);
            Console.WriteLine($"Números: {todos}");
            Console.WriteLine("Le gusta impares o pares (p/i):");
            string poi = Console.ReadLine();

            if (poi == "p")
            {
                sl = sl + par;
                Console.WriteLine("Elementos pares: " + sl);
            }

            else if (poi == "i")
            {

                sl = sl + impar;
                Console.WriteLine("Elementos impares: " + sl);
            }








        }

    }
}
