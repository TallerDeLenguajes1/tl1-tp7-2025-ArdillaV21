namespace EspacioEmpleado
{
    public enum Cargos : int
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5
    }

    public class Empleado
    {
        string nombre;
        string apellido;
        DateTime fechaDeNacimiento;
        char estadoCivil;
        DateTime fechaIngreso;

        double sueldoBasico;
        Cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }


        public int antiguedad(DateTime fechaIngreso)
        {
            return DateTime.Now.Year - fechaIngreso.Year;
        }

        public int edadEmpleado(DateTime fechaDeNacimiento)
        {
            return DateTime.Now.Year - fechaDeNacimiento.Year;
        }

        public int AñosParaJubilacion(DateTime fechaDeNacimiento)
        {
            return 65 - (DateTime.Now.Year - fechaDeNacimiento.Year);
        }

        public double Salario()
        {
            double Adicional = 0;
            int Antiguedad = antiguedad(fechaIngreso);
            if (Antiguedad >= 20)
            {
                Adicional = sueldoBasico * 1.25;
            }
            else
            {
                Adicional = sueldoBasico*0.1 * Antiguedad;
            }

            if(cargo == Cargos.Especialista || cargo == Cargos.Ingeniero)
            {
                Adicional *= 1.50;
            }

            if(estadoCivil == 'c')
            {
                Adicional+= 150000;
            }

            return Adicional;
        }
        
    }

    
}