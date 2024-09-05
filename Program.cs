namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Fibonacci");
            Console.WriteLine("2. Factorial");
            Console.WriteLine("3. Suma de números anteriores");
            Console.WriteLine("4. Pirámide");
            Console.WriteLine("5. Verificar Palíndromo");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Fibonacci();
                    break;
                case 2:
                    Factorial();
                    break;
                case 3:
                    SumaNumerosAnteriores();
                    break;
                case 4:
                    Piramide();
                    break;
                case 5:
                    VerificarPalindromo();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void Fibonacci()
        {
            Console.Write("Ingrese la cantidad de veces: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;

            Console.WriteLine("Secuencia de Fibonacci:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        // Función para calcular el factorial de un número
        static void Factorial()
        {
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial de " + num + " es: " + factorial);
        }

        // Función para sumar todos los números anteriores a un número ingresado
        static void SumaNumerosAnteriores()
        {
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int suma = 0;

            for (int i = 1; i <= num; i++)
            {
                suma += i;
            }

            Console.WriteLine("La suma de todos los números anteriores a " + num + " es: " + suma);
        }

        // Función para imprimir una pirámide de 'x'
        static void Piramide()
        {
            Console.Write("Ingrese la altura de la pirámide: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                Console.WriteLine(new string(' ', altura - i) + new string('x', 2 * i - 1));
            }
        }

        // Función para verificar si una frase es un palíndromo
        static void VerificarPalindromo()
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine().Replace(" ", "").ToLower();
            string fraseInvertida = new string(frase.Reverse().ToArray());

            if (frase == fraseInvertida)
            {
                Console.WriteLine("La frase es un palíndromo.");
            }
            else
            {
                Console.WriteLine("La frase no es un palíndromo.");
            }
        }

    }
}
