namespace EspacioCalculadora;

public class Calculadora{
    private double dato;
    public double Dato { get => dato; set => dato = value; }
    public void Sumar(double termino){
        dato+=termino;
    }
    public void Restar( double termino){
        dato-=termino;
    }
    public void Multiplicar(double termino){
        dato*=termino;
    }
    public void Dividir(double termino){
        if(termino != 0){
            dato/=termino;
        }else{
            Console.WriteLine("Error: Division en 0");
        }
    }
    public void Limpiar(){
        dato = 0;
    }
    public double Resultado => dato;

};