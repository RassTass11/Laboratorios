using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Nueva_carpeta;


public class Program{
public double precio=20;
    static void Main(string[] args){
        string name="";
        string confirmacion="";
        


        Azucar azu=new Azucar();
        Leche lec=new Leche();
        Agrandado grande=new Agrandado();

        Console.WriteLine("A continuacion ingrese su nombre");
        name = Console.ReadLine();
        Console.WriteLine("Bienvenido: "+name);
        Console.WriteLine("Desea agregar nit, si o no?");
        confirmacion=Console.ReadLine();
        if (confirmacion=="si"){
            int nit=0;
            Console.WriteLine("Ingrese su nit:");
            nit = int.Parse(Console.ReadLine());
        }else if(confirmacion=="no"){
            int nit=0;
        }

    //menu
    for (int i=0; i<1;){
    string p1="";
    Console.WriteLine("A continuacion llene el formulario, esriba si, si desea agregar, escriba no si no desea agregar");
    Console.WriteLine("Desea Azucar");
    p1=Console.ReadLine();
    if (p1=="si"){
        Console.WriteLine(azu.achucar("",""));
    }
    else{
        Console.WriteLine("Entendido gracias");
    }

    Console.WriteLine("Desea Leche");
    p1=Console.ReadLine();
    if (p1=="si"){
    Console.WriteLine(lec.leshe("",""));
    }
    else{
        Console.WriteLine("Entendido gracias");
    }

    Console.WriteLine("Desea Agrandar");
    p1=Console.ReadLine();
    if (p1=="si"){
    Console.WriteLine(grande.grand(""));        
    }
    else{
        Console.WriteLine("Entendido gracias");
        grande.nope("");
    }
    
    Console.WriteLine("Desea Salir");
    p1=Console.ReadLine();
    if (p1=="si"){
    Console.WriteLine("Tenga un bonito dia");
    Console.WriteLine("Pase a cancelar a caja, el precio de su batido es: "+grande.precion);
    i=1;
    }
    else{
        Console.WriteLine("Valio queso tena buen dia");
        i=0;
    }
    
    }
}
}
