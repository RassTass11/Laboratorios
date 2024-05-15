namespace L12_Josué_Reyes_1029024;

public class Circulo
{
 private double r;  //radio
     public Circulo(double r){
            this.r = r;
     }

        private double ObtenerPerimetro(){
            double P = (2*r)*Math.PI;
            return P;
        }

        private double ObtenerArea(){
            double A = (r*r)*Math.PI;
            return A;
        }

        private double ObtenerVolumen(){
            double V = (4*Math.PI* (Math.Pow(r,3)))/3;
            return V;
        }

        public void CalcularGeometria(ref double P, ref double A, ref double V){
           P = ObtenerPerimetro();
            A = ObtenerArea();
            V = ObtenerVolumen();
            
        }

}
