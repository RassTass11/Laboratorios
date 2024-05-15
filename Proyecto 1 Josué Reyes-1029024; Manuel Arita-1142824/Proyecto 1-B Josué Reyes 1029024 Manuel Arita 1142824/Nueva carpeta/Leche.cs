using System.Security.Cryptography;

namespace Nueva_carpeta;

public class Leche
{
    Program pp=new Program();
    Azucar azu=new Azucar();

Azucar precioz=new Azucar();
public string lechoso ="";
public double precio1=-3;
public double precio2=0;
public double precio3=2;
public static double leche=0;
public static double preciol=0.0;
public string leshe( string l2, string l3){
int l1=0;
    Console.WriteLine("Elija su tipo de leche");
    Console.WriteLine("1-Sin leche");
    Console.WriteLine("2-Entera");
    Console.WriteLine("3-Deslactosada");
    Console.WriteLine("4-Soya");
    l1=int.Parse(Console.ReadLine());
    double preciolo=0.0;

    if(l1==1){
        preciolo=precio1;
        Console.WriteLine("Al no optar por leche obtiene un descuento de Q3");
        lechoso="Sin leche";  
        }
    if(l1==2){
        preciolo=precio2;
        Console.WriteLine("El optar por leche entra no obtiene un monto extra");
        lechoso="Entera";
    }
    if(l1==3){
       preciolo=precio2;
        Console.WriteLine("El optar por leche deslactosada no obtiene un monto extra");
        lechoso="Deslactosada";
    }
    if(l1==4){
        preciolo=precio3;
        Console.WriteLine("El optar por leche de soya obtiene un monto extra de Q2");
        lechoso="Soya";
    }  
    leche=azu.ActualizarPrecioz(0)+preciolo;
    double preciolactualizado = Actualizarpreciol(preciolo);
    double lecheactualizado = Actualizarleche(leche);
    l3="Usted escogio: "+lechoso+", el costo total es de: "+leche;
    return l3;

}
public double Actualizarpreciol(double preciolo){
    double preciolactualizado=0;
    preciolactualizado=preciolo; 
    preciol = preciolactualizado; 
    return preciol; 
}
public double Actualizarleche(double lechenuevo){
    double lecheactualizado=0;
    lecheactualizado=lechenuevo+preciol; 
    leche = lecheactualizado; 
    return leche; 
}


}
