using Microsoft.VisualBasic;

class lab7
{
    static void Main(string[] args)
    {

int NFibonacci;
bool conversión = false;
bool nPositivo = false;

Console.WriteLine("Parte 1");
Console.WriteLine("Serie Fibonacci");
do{
    Console.WriteLine("Ingrese un número mayor a 0");
    conversión = int.TryParse(Console.ReadLine(), out NFibonacci);
    if (conversión){
        if(NFibonacci >0){
            nPositivo = true;
        }
    }
   
}
while (!conversión || !nPositivo);

int A = 0;
int B = 1;
int C = 0;
int I = 2;
string resultado="";

if (NFibonacci > 0){
    resultado = A+", ";

    if (NFibonacci>1){
        resultado +=B+", ";
while (I<NFibonacci){
    C = A + B;
    resultado +=C+", ";
    A=B;
    B=C;
    I=I+1;
} Console.WriteLine("Su sucesión es "+resultado);

}
}
else {
    Console.WriteLine($"Su resultado es {resultado}");
}
Console.WriteLine();
Console.WriteLine("Parte 2");
Console.WriteLine();

int n;
int c=0;
int x=1;
double division;
string d="";
string div="";
string divt="";

Console.WriteLine("Sucesión (1/1) + (1/2) + (1/3) + … + (1/n)");
Console.WriteLine();
Console.WriteLine("Escriba un número mayor a 0");
n = int.Parse(Console.ReadLine());
Console.WriteLine();

if (n<=0){
    Console.WriteLine("Su número no es valido, ingrese otro mayor a 0");
    int.TryParse(Console.ReadLine(), out n);
}

while (c!=n){
    
    division = 1/x;
    d += division +" + ";
    div= $"(1/{x})";
    divt +=div+" + ";
    x++;
    c++;
}
Console.WriteLine("Su sucesión es");
Console.WriteLine(divt);
Console.WriteLine(d);
Console.WriteLine();

int e;
int c1=0;
int n1=1;
double divp;
string p="";
string dp="";
string divpt="";

Console.WriteLine("Sucesión (1/2^1) + (1/2^2) + (1/2^3) + … + (1/2^e)");
Console.WriteLine();
Console.WriteLine("Escriba un número mayor a 0");
e = int.Parse(Console.ReadLine());
Console.WriteLine();

if (e<=0){
    Console.WriteLine("Su número no es valido, ingrese otro mayor a 0");
    int.TryParse(Console.ReadLine(), out e);
}
while (c1!=e){
    
    divp = 1/(Math.Pow(2, n1));
    p += divp +" + ";
    dp= $"(1/2^{n1})";
    divpt +=dp+" + ";
    n1++;
    c1++;

}
Console.WriteLine("Su sucesión es");
Console.WriteLine(divpt);
Console.WriteLine(p);
Console.WriteLine();

int k=0;
int c2=0;
int x1;
int a;
int n2;
double prod=0;
double sum=0;
string t ="";

Console.WriteLine("Sumatoria n veces de (x^k)*(a^n-k). k=0");
Console.WriteLine();
Console.WriteLine("Ingrese el valor entero x");
x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor entero a");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor entero n");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine();

while (c2 != n2){
prod = ((Math.Pow(x, k))) * (Math.Pow(a, (n2-k)));
t += prod +" + ";
sum = prod * n2;
c2++;

}
Console.WriteLine($"Se sumara {n2} veces (({x1}^0)*({a}^{n2}-0))={prod}");
Console.WriteLine(t);
Console.WriteLine(sum);

    }
}


















