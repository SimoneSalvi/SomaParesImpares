internal class Program
{
    private static void Main(string[] args)
    {

        int numero = 0;
        int somaPares = 0;
        int somaImpares = 0;

        Console.WriteLine("Informe o numero");
        numero = int.Parse(Console.ReadLine());

        while (numero < 1000)
        {
            if (numero % 2 == 0)
            {

                somaPares += numero;
            }
            else
            {

                somaImpares += numero;
            }

            Console.WriteLine("Informe o numero");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Soma pares = " + somaPares + ", e soma impares = " + somaImpares);





    }
}