using System.Diagnostics;

class L8
{
    static void Main(String[] args)
    {

        int opcion = 0;
        string entrada;

        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1) Sumatoria");
            Console.WriteLine("2) Factorial");
            Console.WriteLine("3) Tablas de multiplicar");
            Console.WriteLine("4) Salir");

            Console.WriteLine("Seleccione una opción");
            entrada = Console.ReadLine();

            try
            {
                opcion = int.Parse(entrada);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Sumatoria de un número");
                        Console.WriteLine("Ingrese un número positivo");
                        string entradaNumero = Console.ReadLine();
                        int n = 0;

                        try
                        {
                            n = int.Parse(entradaNumero);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error, ingrese un número válido");
                        }

                        int i = 1;
                        int sumatoria = 0;

                        while (i <= n)
                        {
                            sumatoria += i; // sumatoria = sumatoria + i
                            i++;
                        }
                        Console.WriteLine($"Sumatoria: {sumatoria}");
                        break;

                    case 2:
                        Console.WriteLine("Factorial de un número");
                        Console.WriteLine("Ingrese un número positivo");

                        string entradanF = Console.ReadLine();
                        int nF = 0;

                        try
                        {
                            nF = int.Parse(entradanF);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error, ingrese un número válido");
                        }

                        int j = 1;
                        int factorial = 1;

                        while (j <= nF)
                        {
                            factorial *= j; // factorial = factorial * j
                            j++;
                        }
                        Console.WriteLine($"Factorial: {factorial}");
                        break;

                    case 3:
                        Console.WriteLine("Tablas de multiplicar");
                        string titulo = "\t";
                        for (int iTitulo = 1; iTitulo <= 10; iTitulo++)
                        {
                            titulo += iTitulo + "\t";
                        }
                        Console.WriteLine(titulo);
                        Console.WriteLine();
                        string fila = "";
                        for (int ifila = 1; ifila <= 10; ifila++)
                        {

                            fila = ifila + "\t";

                            for (int multiplo = 1; multiplo <= 10; multiplo++)
                            {
                                fila += ifila * multiplo + "\t";
                            }
                            Console.WriteLine(fila);

                        }
                        break;

                    case 4:
                        Console.WriteLine("Hasta pronto");
                        break;
                    default:
                        Console.WriteLine("Error, escriba un número del 1-4");
                        break;
                }

            }
            catch (FormatException)

            {
                Console.WriteLine("Error");
            }

        } while (opcion != 4);
    }
}