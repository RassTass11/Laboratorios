using System.Diagnostics;

class Program
{ static void Main(string[] args)
    {
Console.WriteLine("Parte 1 Ejercicio 1");

string nombre;

        Console.WriteLine("Hola mundo");
        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola " + nombre);
        
        Console.WriteLine("Parte 2 Ejercicio 1");
        double X;
        double Y;
        double suma;
        double resta;
        double multiplicacion;
        double division;
        double mod;
        Console.WriteLine("Ingrese el primer número");
        X = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        Y = double.Parse(Console.ReadLine());
        suma = X + Y;
        resta = X - Y;
        multiplicacion = X * Y;
        division = X/Y;
        mod = X%Y;
        Console.WriteLine("La suma de "+X+" y "+Y+" es igual a "+suma);
        Console.WriteLine("La resta de "+X+" y "+Y+" es igual a "+resta);
        Console.WriteLine("La multiplicación de "+X+" y "+Y+" es igual a "+multiplicacion);
        Console.WriteLine("La división de "+X+" y "+Y+" es igual a "+division);
        Console.WriteLine("El residuo de la división de "+X+" y "+Y+" es igual a "+mod);

        Console.WriteLine("Parte 3 Ejercicio 1");

        bool mayor = X>Y;
        bool menor = X<Y;
        bool igual = X==Y;

        Console.WriteLine(X+" es mayor que "+Y+"? "+mayor);
        Console.WriteLine(X+" es menor que "+Y+"? "+menor);
        Console.WriteLine(X+" es igual que "+Y+"? "+igual);

Console.WriteLine("Parte 3 Ejercicio 1");

double Z; 
double multi1;
double multi2;
double div1;
double div2;
Console.WriteLine("Ingrese un tercer número");
Z = double.Parse(Console.ReadLine());
multi1 = X*Y+Z;
multi2 = X*(Y+Z);
div1 = X/(Y*Z);
div2 = ((3*X)+(2*Y))/(Math.Pow(Z,2));

Console.WriteLine("El resultado de X*Y+Z es "+multi1);
Console.WriteLine("El resultado de X*(Y+Z) es "+multi2);
Console.WriteLine("El resultado de X/(Y*Z) es "+div1);
Console.WriteLine("El resultado de (3*X)+(2*Y)/Z^2 es "+div2);

Console.WriteLine("Parte 4 Ejercicio 1");

 double a;
 double b;
 double c;
 
 Console.WriteLine("Ingrese el valor a");
 a = double.Parse(Console.ReadLine());
 Console.WriteLine("Ingrese el valor b");
 b = double.Parse(Console.ReadLine());
 Console.WriteLine("Ingrese el valor c");
 c = double.Parse(Console.ReadLine());


 {
if (a==0)
     {
        Console.WriteLine("a no puede ser 0, ingrese otro valor");
        a = double.Parse(Console.ReadLine());
    };
 }
 double discrim; 
 double cuadr1;
 double cuadr2;


 discrim = (Math.Pow(b,2))-(4*a*c);   
 cuadr1 = ((-1*b)+(Math.Sqrt(discrim)))/(2*a);
 cuadr2 = ((-1*b)-(Math.Sqrt(discrim)))/(2*a);
 
  bool condición1 = discrim>=0;



    {
        if(condición1)
        {
        Console.WriteLine("Los valores resultantes de la ecuación cuadratica son: "+cuadr1+" y "+cuadr2);
        }
        else 
          {
    
        Console.WriteLine("Sus valores no son validos");
     
    }
    }
    }
}

    
    


