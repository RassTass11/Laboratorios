using System.Security.Cryptography;

namespace Nueva_carpeta;

public class Azucar
{
    Program pp=new Program();

public string azucar ="";
public double precio1=0.50;
public double precio2=0.40;
public double precio3=0.90;
public static double precio4=0;
public int cucharada=0;
public static double precioz=0;

public string achucar( string n2, string n3){
    int n1=0;
    Console.WriteLine("Elija su tipo de azucar");
    Console.WriteLine("1-Blanca");
    Console.WriteLine("2-Morena");
    Console.WriteLine("3-Suplemento(Splenda, Stevia, etc)");
    n1=int.Parse(Console.ReadLine());

    
    double precio4nuevo=0;
    if(n1==1){
        
        Console.WriteLine("Cuantas cucharadas desea 1-3");
        cucharada=int.Parse(Console.ReadLine());
        if(cucharada==1){precio4nuevo=precio1*1;}
        if(cucharada==2){precio4nuevo=precio1*2;}
        if(cucharada==3){precio4nuevo=precio1*3;}
        if(cucharada>4){
            Console.WriteLine("Error en la tabulacion de datos");
        }
    }
    if(n1==2){
        
        Console.WriteLine("Cuantas cucharadas desea 1-3");
        cucharada=int.Parse(Console.ReadLine());
        if(cucharada==1){precio4nuevo=precio2*1;}
        if(cucharada==2){precio4nuevo=precio2*2;}
        if(cucharada==3){precio4nuevo=precio2*3;}
        if(cucharada>4){
            Console.WriteLine("Error en la tabulacion de datos");
        }
    }
    if(n1==3){

        Console.WriteLine("Cuantas cucharadas desea 1-3");
        cucharada=int.Parse(Console.ReadLine());
        if(cucharada==1){precio4nuevo=precio3*1;}
        if(cucharada==2){precio4nuevo=precio3*2;}
        if(cucharada==3){precio4nuevo=precio3*3;}
        if(cucharada>4){
            Console.WriteLine("Error en la tabulacion de datos");
        }
    }
    switch(n1){
        case 1:
        azucar="Blanca";
        break;
        case 2:
        azucar="Morena";
        break;
        case 3:
        azucar="Suplemento";
        break;
    }
    double precio4actualizado = ActualizarPrecio4(precio4nuevo);
    double preciozactualizado = ActualizarPrecioz(precioz);
    n3="Usted añadio: "+cucharada+", de azucar: "+azucar+", el coso total es de: "+preciozactualizado;
    
    return n3;

}
public double ActualizarPrecio4(double precio4nuevo){
    double precio4actualizado=0;
    precio4actualizado=precio4nuevo; 
    precio4 = precio4actualizado; 
    return precio4; 
}
public double ActualizarPrecioz(double precios){
    double preciozactualizado=0;
    preciozactualizado=precio4+20; 
    precios = preciozactualizado; 
    return precios; 
}


}
