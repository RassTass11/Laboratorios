class Lab_6
{
    static void Main(string[] args)
{
Console.WriteLine("Ejercicio 1");
int numeroMes;
string entradaMes;
string mesCadena;

Console.WriteLine("Ingrese un número del 1 al 12 para mostrar el nombre del mes");
entradaMes = Console.ReadLine();

if(int.TryParse(entradaMes, out numeroMes))     
{
    Console.WriteLine($"Se convirtió '{entradaMes}' a '{numeroMes}'");
}
else
{ 
    Console.WriteLine("Error: Ingrese un número del 1 al 12");
}
Console.WriteLine(numeroMes);

switch(numeroMes)
{
    case 1:
    mesCadena = "Enero";
    break;

    case 2:
    mesCadena = "Febrero";
    break;

    case 3:
    mesCadena = "Marzo";
    break;

    case 4:
    mesCadena = "Abril";
    break;

    case 5:
    mesCadena = "Mayo";
    break;

    case 6:
    mesCadena = "Junio";
    break;

    case 7:
    mesCadena = "Julio";
    break;

    case 8:
    mesCadena = "Agosto";
    break;

    case 9:
    mesCadena = "Septiembre";
    break;

    case 10:
    mesCadena = "Octubre";
    break;

    case 11:
    mesCadena = "Noviembre";
    break;

    case 12:
    mesCadena = "Diciembre";
    break;
    
    default:
    mesCadena = "";
    Console.WriteLine("Error: Porfavor ingrese un número del 1 al 12");
    break;
    
}

Console.WriteLine($"Mes: '{mesCadena}'");

Console.WriteLine("Ejercicio 2");
 
 int a;
 int b;
 int c;

 Console.WriteLine("Ingrese tres números enteros mayores a 0");
 int.TryParse(Console.ReadLine(), out a);
 int.TryParse(Console.ReadLine(), out b);
 int.TryParse(Console.ReadLine(), out c);
 
if (a <= 0)
{
    Console.WriteLine("Error: A no debe ser entero y no puede ser 0, cambielo");
    int.TryParse(Console.ReadLine(), out a);
}
if(b <= 0)
{
    Console.WriteLine("Error: B no debe ser entero y no puede ser 0, cambielo");
    int.TryParse(Console.ReadLine(), out b);
}
if (c <= 0)
{
    Console.WriteLine("Error: C no debe ser entero y no puede ser 0, cambielo");
    int.TryParse(Console.ReadLine(), out c);
}

if (a>b)
{
    if (a>c)
    {
        Console.WriteLine($"'{a}' es mayor que '{c}'");

    }
    else 
    {
        if (a==c)
        {
            Console.WriteLine($"'{a}' es igual '{c}'");
        }
        else
        {
            Console.WriteLine($"'{a}' no es igual a '{c}'");
        }
    }
}
else 
{
    if (a==b)
    {
        if (a>c)
        {
            Console.WriteLine($"'{a}' es mayor que '{c}'");
        }
        else 
        {
            if (a==c)
            {
                Console.WriteLine($"'{a}' es igual que '{c}'");
            }
            else
            {
                Console.WriteLine($"'{a}' no es igual que '{c}'");
            }
        }
    }
    else {
        if (b>c)
        {
            Console.WriteLine($"'{b}' es mayor que '{c}'");
        }
        else
        {
            if (b==c)
            {
                Console.WriteLine($"'{b}' es igual a '{c}'");
            }
            else
            {
                Console.WriteLine($"'{b}' no es igual a '{c}'");
            }
        }
    }
}


Console.WriteLine("Ejercicio 3");
 int año;
 int mesnum;
 string mes;
 string mesletras;
 int dia;

 Console.WriteLine("Escriba su año de nacimiento");
 año = int.Parse(Console.ReadLine());

Console.WriteLine("Escriba numero de mes que nacio");
mes = Console.ReadLine();

if(int.TryParse(mes, out mesnum))
{
    Console.WriteLine($"Se convirtió '{mes}' a '{mesnum}'");
}
else
{ 
    Console.WriteLine("Error: Ingrese un numero valido (1-12).");
}
Console.WriteLine(mesnum);

switch(mesnum)
{
    case 1:
    mesletras = "Enero";
    break;

    case 2:
    mesletras = "Febrero";
    break;

    case 3:
    mesletras = "Marzo";
    break;

    case 4:
    mesletras = "Abril";
    break;

    case 5:
    mesletras = "Mayo";
    break;

    case 6:
    mesletras = "Junio";
    break;

    case 7:
    mesletras = "Julio";
    break;

    case 8:
    mesletras = "Agosto";
    break;

    case 9:
    mesletras = "Septiembre";
    break;

    case 10:
    mesletras = "Octubre";
    break;

    case 11:
    mesletras = "Noviembre";
    break;

    case 12:
    mesletras = "Diciembre";
    break;
    
    default:
    mesletras = "";
    Console.WriteLine("Error: Porfavor ingrese un número del 1 al 12");
    break;
    
}

Console.WriteLine("Escriba que numero de día del mes nacio");
dia = int.Parse(Console.ReadLine());


if (31 >= dia && dia>= 1)
{
Console.WriteLine("Su fecha de nacimento completa es:");
Console.WriteLine(dia + " de " +mesletras+ " de " +año);
}
else
{
    Console.WriteLine("Su fecha de nacimiento no es válida, ingrese un dia valido");
    int.TryParse(Console.ReadLine(), out dia);
    Console.WriteLine("Su fecha de nacimento completa es:");
    Console.WriteLine(dia + " de " +mesletras+ " de " +año);
}

if (((dia>=20 && dia<=31)&& mesnum == 1)||((dia>=1 && dia<=18)&&mesnum == 2))
{ Console.WriteLine("Su signo zodiacal es acuario");}

else if (((dia>=19 && dia<=29)&& mesnum == 2)||((dia>=1 && dia<=20)&&mesnum == 3))
{Console.WriteLine("Su signo zodiacal es piscis");}

else if (((dia>=21 && dia<=31)&& mesnum == 3)||((dia>=1 && dia<=19)&&mesnum == 4))
{Console.WriteLine("Su signo zodiacal es aries");}

else if (((dia>=20 && dia<=30)&& mesnum == 4)||((dia>=1 && dia<=20)&&mesnum == 5))
{Console.WriteLine("Su signo zodiacal es tauro");}

else if (((dia>=21 && dia<=31)&& mesnum == 5)||((dia>=1 && dia<=20)&&mesnum == 6))
{Console.WriteLine("Su signo zodiacal es geminis");}

else if (((dia>=21 && dia<=30)&& mesnum == 6)||((dia>=1 && dia<=22)&&mesnum == 7))
{Console.WriteLine("Su signo zodiacal es cancer");}

else if (((dia>=23 && dia<=31)&& mesnum == 7)||((dia>=1 && dia<=22)&&mesnum == 8))
{Console.WriteLine("Su signo zodiacal es leo");}

else if (((dia>=23 && dia<=31)&& mesnum == 8)||((dia>=1 && dia<=22)&&mesnum == 9))
{Console.WriteLine("Su signo zodiacal es virgo");}

else if (((dia>=23 && dia<=30)&& mesnum == 9)||((dia>=1 && dia<=22)&&mesnum == 10))
{Console.WriteLine("Su signo zodiacal es libra");}

else if (((dia>=23 && dia<=31)&& mesnum == 10)||((dia>=1 && dia<=21)&&mesnum == 11))
{Console.WriteLine("Su signo zodiacal es escorpio");}

else if (((dia>=22 && dia<=30)&& mesnum == 11)||((dia>=1 && dia<=21)&&mesnum == 12))
{Console.WriteLine("Su signo zodiacal es sagitario");}

else if (((dia>=22 && dia<=31)&& mesnum == 12)||((dia>=1 && dia<=19)&&mesnum == 1))
{Console.WriteLine("Su signo zodiacal es capricornio");}

else
{Console.WriteLine("Su fecha de nacimiento no es valida");}

}
}   