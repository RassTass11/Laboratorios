class Areas
{


    public double AreaTriangulo(double bT, double hT)
    {

        Console.WriteLine("Ingrese el valor de la altura y la base del triangulo");
        bT = double.Parse(Console.ReadLine());
        hT = double.Parse(Console.ReadLine());

        double areaT = (bT * hT) / 2;   
        return areaT;

    }


    public double AreaCuadrado(double L)
    {

        Console.WriteLine("Ingrese el valor de un lado del cuadrado");
        L = double.Parse(Console.ReadLine());

        double areaCuad = L * L;
        return areaCuad;
    }

    public double AreaRectangulo(double bR, double hR)
    {

        Console.WriteLine("Ingrese el valor de la altura y la base del rectangulo");
        bR = double.Parse(Console.ReadLine());
        hR = double.Parse(Console.ReadLine());

        double areaRec = bR * hR;
        return areaRec;
    }

    public double AreaCirculo(double r)
    {

        Console.WriteLine("Ingrese el valor del radio del circulo");
        r = double.Parse(Console.ReadLine());

        double areaCirc = Math.PI * (r * r);
        return areaCirc;

        
    }
}