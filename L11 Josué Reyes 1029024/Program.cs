class program
{

    static void Main(string[] args)
    {

        string opcion;

        Personaje personaje = new Personaje(0, 0);


        do
        {

            Console.WriteLine("a. Sube");
            Console.WriteLine("b. Baja");
            Console.WriteLine("c. Izquierda");
            Console.WriteLine("d. Derecha");
            Console.WriteLine("e. Salir");

            Console.WriteLine("Ingrese la opcion");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "a":
                    personaje.MoverHaciaArriba(LeerCantidad("arriba"));
                    break;

                case "b":

                    personaje.MoverHaciaAbajo(LeerCantidad("abajo"));
                    break;

                case "c":
                    personaje.MoverHaciaDerecha(LeerCantidad("izquierda"));
                    break;

                case "d":
                    personaje.MoverHaciaIzquierda(LeerCantidad("derecha"));
                    break;

                case "e":
                    Console.WriteLine($"Coordenadas finales del personaje: {personaje.GetX()}, {personaje.GetY()}");
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        } while (opcion != "e");

        static int LeerCantidad(string direccion)
        {
            Console.WriteLine($"Ingrese la cantidad a moverse hacia {direccion}");
            int cantidad = int.Parse(Console.ReadLine());
            return cantidad;
        }


        Console.WriteLine("Parte 2");
        Areas tipoArea = new Areas();

        string opcion2;

        do
        {

            Console.WriteLine("a. Area Triangulo");
            Console.WriteLine("b. Area Cuadrado");
            Console.WriteLine("c. Area Rectangulo");
            Console.WriteLine("d. Area Circulo");
            Console.WriteLine("e. Salir");

            Console.WriteLine("Ingrese la opcion");
            opcion2 = Console.ReadLine();

            switch (opcion2)
            {
                case "a":
                    double areaTri = tipoArea.AreaTriangulo(0, 0);
                    Console.WriteLine($"El area del triangulo es de {areaTri} cm");
                    break;

                case "b":
                    double areaC = tipoArea.AreaCuadrado(0);
                    Console.WriteLine($"El area del cuadrado es de {areaC} cm");
                    break;

                case "c":
                    double areaRec = tipoArea.AreaRectangulo(0, 0);
                    Console.WriteLine($"El area del rectangulo es de {areaRec} cm");
                    break;

                case "d":
                    double areaCir = tipoArea.AreaCirculo(0);
                    Console.WriteLine($"El area del circulo es de {areaCir} cm");
                    break;

                case "e":
                    Console.WriteLine("Vuelva Pronto");
                    break;

                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }
        } while (opcion2 != "e");

    }
}
