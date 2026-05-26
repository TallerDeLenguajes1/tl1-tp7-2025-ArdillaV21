namespace EspacioCalculadora{
    public class Calculadora
    {
        private double dato;

        public double Dato
        {
            get => dato;
            set => dato = value;
        }
        
        public void Sumar(double termino)
        {
            dato+=termino;   
        }

        public void Restar(double termino)
        {
            dato-=termino;
        }

        
    }
}