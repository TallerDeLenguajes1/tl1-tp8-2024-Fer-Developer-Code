using EspacioCalculadora;
using EspacioOperacion;
using espacioTipoOperacion;
double termino = 0;
using EspacioOperacion;
using espacioTipoOperacion;
double termino = 0;
int opcion;
string? linea;
Calculadora calcular = new Calculadora();
do
{
    Console.WriteLine("opciones a elegir\n\t1.Sumar\n\t2.Restar\n\t3.Multiplicar\n\t4.Dividir\n\t5.Limpiar\n\t6.Mostrar historial\n\t7.Salir\nEscriba aca la opcion");
    linea = Console.ReadLine();
    if (int.TryParse(linea, out opcion))
    if (int.TryParse(linea, out opcion))
    {
        if (opcion >= 1 && opcion <= 7)
        if (opcion >= 1 && opcion <= 7)
        {


            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese un termino para operar en suma");
                    linea = Console.ReadLine();
                    if (double.TryParse(linea, out termino))
                    {
                        calcular.Sumar(termino);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido para la suma");
                    }
                    Console.WriteLine("Ingrese un termino para operar en suma");
                    linea = Console.ReadLine();
                    if (double.TryParse(linea, out termino))
                    {
                        calcular.Sumar(termino);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido para la suma");
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese un termino para operar en resta");
                    linea = Console.ReadLine();
                    if (double.TryParse(linea, out termino))
                    {
                        calcular.Restar(termino);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido para la resta");
                    }
                    Console.WriteLine("Ingrese un termino para operar en resta");
                    linea = Console.ReadLine();
                    if (double.TryParse(linea, out termino))
                    {
                        calcular.Restar(termino);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido para la resta");
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese un termino para operar en multiplicacion");
                    linea = Console.ReadLine();
                    if (double.TryParse(linea, out termino))
                    {
                        calcular.Multiplicar(termino);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido para la multiplicacion");
                    }
                    Console.WriteLine("Ingrese un termino para operar en multiplicacion");
                    linea = Console.ReadLine();
                    if (double.TryParse(linea, out termino))
                    {
                        calcular.Multiplicar(termino);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido para la multiplicacion");
                    }
                    break;
                case 4:
                    Console.WriteLine("Ingrese un termino para operar en division");
                    linea = Console.ReadLine();
                    if (double.TryParse(linea, out termino))
                    {
                        calcular.Dividir(termino);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido para la division");
                    }
                    Console.WriteLine("Ingrese un termino para operar en division");
                    linea = Console.ReadLine();
                    if (double.TryParse(linea, out termino))
                    {
                        calcular.Dividir(termino);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido para la division");
                    }
                    break;
                case 5:
                    calcular.Limpiar();
                    break;
                case 6:
                    Console.WriteLine("Historial de operaciones");
                    foreach (Operacion operacionIndividual in calcular.HistorialOperaciones)
                    {
                        switch (operacionIndividual.OperacionHecha)
                        {
                            case TipoOperacion.Suma:
                                Console.WriteLine($"A las {operacionIndividual.HoraYMinutos.Hour}:{operacionIndividual.HoraYMinutos.Minute.ToString("00")}");
                                Console.WriteLine($"\tSuma: {operacionIndividual.Resultado} + {termino} = {operacionIndividual.NuevoValor}");
                                break;
                            case TipoOperacion.Resta:
                                Console.WriteLine($"A las {operacionIndividual.HoraYMinutos.Hour}:{operacionIndividual.HoraYMinutos.Minute.ToString("00")}");
                                Console.WriteLine($"\tResta: {operacionIndividual.Resultado} - {termino} = {operacionIndividual.NuevoValor}");
                                break;
                            case TipoOperacion.Multiplicacion:
                                Console.WriteLine($"A las {operacionIndividual.HoraYMinutos.Hour}:{operacionIndividual.HoraYMinutos.Minute.ToString("00")}");
                                Console.WriteLine($"\tMultiplicacion: {operacionIndividual.Resultado} * {termino} = {operacionIndividual.NuevoValor}");
                                break;
                            case TipoOperacion.Division:
                                Console.WriteLine($"A las {operacionIndividual.HoraYMinutos.Hour}:{operacionIndividual.HoraYMinutos.Minute.ToString("00")}");
                                Console.WriteLine($"\tDivision: {operacionIndividual.Resultado} / {termino} = {operacionIndividual.NuevoValor}");
                                break;
                            case TipoOperacion.Limpiar:
                                Console.WriteLine($"A las {operacionIndividual.HoraYMinutos.Hour}:{operacionIndividual.HoraYMinutos.Minute.ToString("00")}");
                                Console.WriteLine("\tLimpiar: termino = 0");
                                break;
                        }
                    }
                    break;
                case 7:
                    Console.WriteLine("Gracias por usar la calculadora");
                    opcion = 7;
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }
            Console.WriteLine("El resultado es: " + calcular.Resultado);
        }
        else
        {
            Console.WriteLine("Ingrese un valor valido");
        }
    }
    else
    {
        Console.WriteLine("Ingrese una opcion valida");
    }
    else
    {
        Console.WriteLine("Ingrese una opcion valida");
    }
} while (opcion != 7);