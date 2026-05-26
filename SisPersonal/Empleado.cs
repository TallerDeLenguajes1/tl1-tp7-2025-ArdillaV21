namespace EspacioEmpleado
{
    public class Empleado
    {
        string Nombre;
        string Apellido;
        DateTime FechaDeNacimiento;
        char EstadoCivil;
        DateTime FechaIngreso;

        double SueldoBasico;

        enum cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
        cargos Cargo;

        public int antiguedad(DateTime FechaIngreso)
        {
            return DateTime.Now().Year - FechaIngreso.Year;
        }

        public int edadEmpleado(DateTime FechaDeNacimiento)
        {
            return DateTime.Now().Year - FechaDeNacimiento.Year;
        }

        public int AñosParaJubilacion(DateTime FechaDeNacimiento)
        {
            return (65 - (DateTime.Now().Year - FechaDeNacimiento.Year));
        }
        
    }
}