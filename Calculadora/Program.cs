using EspacioCalculadora;

Calculadora calc = new Calculadora();
string opcion = "";
while(opcion != "x"){
    Console.WriteLine("\n Resultado Actual: ",calc.Resultado);
    Console.WriteLine("\n ¿Que operacion desea realizar?");
    Console.WriteLine("[+]Sumar \n [-]Restar \n [*]Multiplicar \n [/]Dividir \n [c]Limpiar \n [x]Cerrar");
    Console.Write("Ingrese una opcion: \n");
    opcion = Console.ReadLine()?.ToLower() ?? "";
}