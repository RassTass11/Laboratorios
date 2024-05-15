using System.Security.Cryptography;

namespace Nueva_carpeta;

public class Agrandado
{ 
    public double precion=0;
    Program pp=new Program();
    Leche l=new Leche();
    Azucar a=new Azucar();
    public string grand(string a1){
    string ag="";

        Console.WriteLine("Esto representa un aumento del 7% de la bebida");
        precion=l.Actualizarleche(0)+a.ActualizarPrecio4(0)+(pp.precio*1.07);
        a1 = "Entendido gracias";

    return a1;
}
public string nope(string a1){
    string ag="";

        precion=l.Actualizarleche(0)+a.ActualizarPrecio4(0)+pp.precio;
        a1 = "Entendido gracias";

    return a1;
}

}
