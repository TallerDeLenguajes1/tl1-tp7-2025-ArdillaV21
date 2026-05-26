using EspacioCalculadora;

Calculadora MiCalculadora = new Calculadora();

string opcion = "";

while(opcion != "x")
{
    
    Console.WriteLine("[+]Sumar \n [-]Restar \n [*]Multiplicar \n [/]Dividir \n [=]Resultado \n[c]Limpiar \n [x]Cerrar");
    Console.Write("Ingrese una opcion: \n");
    opcion = Console.ReadLine()?.ToLower() ?? "";

    if( opcion== "+" || opcion == "-" || opcion == "*" || opcion == "/"){
        Console.Write("Ingrese un numero: ");
        if(double.TryParse(Console.ReadLine(),out double valor)){
            switch (opcion)
            {
                case "+" : MiCalculadora.Sumar(valor);
                break;
                case "-" : MiCalculadora.Restar(valor);
                break;
                case "*" : MiCalculadora.Multiplicar(valor);
                break;
                case "/" : MiCalculadora.Dividir(valor);
                break;
            }
        }else{
            Console.WriteLine("Opcion Invalida");
        }
    }else if(opcion == "=")
    {
        Console.WriteLine("Resultado: "+ MiCalculadora.Resultado);
    
    }else if(opcion == "c"){
        MiCalculadora.Limpiar();
    }else if(opcion != "x"){
        Console.WriteLine("Opcion Invalida");
    }
}
    