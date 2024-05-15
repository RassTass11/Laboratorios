using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Data;
using System.Numerics;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        OperacionesMatrices operacionesMatrices = new OperacionesMatrices();
        char opcion = 'a';

        operacionesMatrices.CrearMatriz();
        operacionesMatrices.IngresarDatosMatriz();

        while (opcion != 'd')
        {
            Console.WriteLine("Menú opciones");
            Console.WriteLine(" a) Multiplicación de matriz por escalar");
            Console.WriteLine(" b) Buscar dato en matriz");
            Console.WriteLine(" c) Datos pares de la matriz");
            Console.WriteLine(" d) Salir");
            Console.WriteLine("Ingrese opción: ");
            opcion = Console.ReadLine()[0];

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("Ingrese un escalar");
                    int escalar = Int32.Parse(Console.ReadLine());
                   int[,] matrizMult= operacionesMatrices.MultiplicaciónMatrizEscalar(escalar);
                    Console.WriteLine("Matriz Impresa");
                    operacionesMatrices.ImprimirMatriz(matrizMult);
                    break;

                    case 'b':
                    
                    Console.WriteLine("Ingrese el numero que desea buscar");
                    int dato = Int32.Parse(Console.ReadLine());

                    operacionesMatrices.BuscarDato(dato);
                    break;

                    case 'c':
                    int[] arregloN = operacionesMatrices.datoPar();

                    for(int i=0; i<arregloN.Length; i++){
                        Console.WriteLine(arregloN[i]);

                    }

                    break;
            }
        }
    }
}