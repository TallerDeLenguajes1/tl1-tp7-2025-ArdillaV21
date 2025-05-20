using EspacioCalculadora;

Calculadora calc = new Calculadora();
string opcion = "";
while(opcion != "x"){
    Console.WriteLine("\n Resultado Actual: ",calc.Resultado);
    Console.WriteLine("\n ¿Que operacion desea realizar?");
    Console.WriteLine("[+]Sumar \n [-]Restar \n [*]Multiplicar \n [/]Dividir \n [c]Limpiar \n [x]Cerrar");
    Console.Write("Ingrese una opcion: \n");
    opcion = Console.ReadLine()?.ToLower() ?? "";

    if( opcion== "+" || opcion == "-" || opcion == "*" || opcion == "/"){
        Console.Write("Ingrese un numero: ");
        if(double.TryParse(Console.ReadLine(),out double valor)){
            switch (opcion)
            {
                case "+" : calc.Sumar(valor);
                break;
                case "-" : calc.Restar(valor);
                break;
                case "*" : calc.Multiplicar(valor);
                break;
                case "/" : calc.Dividir(valor);
                break;
            }
        }else{
            Console.WriteLine("Opcion Invalida");
        }
    }else if(opcion == "c"){
        calc.Limpiar();
    }else if(opcion != "x"){
        Console.WriteLine("Opcion Invalida");
    }
    }