using L12_Josué_Reyes_1029024;

class Program{
    public static void Main(string[] args){

        Console.WriteLine("Ingrese el radio del circulo");
        double rad = double.Parse(Console.ReadLine());


           Circulo objCirculo = new Circulo(rad);

           double p1=0;
           double A1=0;
           double V1=0;

          objCirculo.CalcularGeometria(ref p1, ref A1, ref V1);

          Console.WriteLine("Perimetro: "+p1);
          Console.WriteLine("Area: "+A1);
          Console.WriteLine("Volumen: "+V1);

    }
}
