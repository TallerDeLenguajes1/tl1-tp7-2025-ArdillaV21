using EspacioEmpleado;

Empleado Empleado1 = new Empleado("Federico","Valle",new DateTime(2001,12,06),'s',new DateTime(2013,01,01), 250000, Cargos.Ingeniero);

Empleado[] Empleados = new Empleado[3];
Empleados[0] = new Empleado("Federico","Valle",new DateTime(2001,12,06),'s',new DateTime(2013,01,01), 250000, Cargos.Ingeniero);
Empleados[1] = new Empleado("Juan","Perez",new DateTime(2003,06,01),'c',new DateTime(2020,05,11), 300000, Cargos.Auxiliar);
Empleados[2] = new Empleado("Sofia","Albornoz",new DateTime(2004,02,27),'c',new DateTime(2015,12,23), 350000, Cargos.Especialista);