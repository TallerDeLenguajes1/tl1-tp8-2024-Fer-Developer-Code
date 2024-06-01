using EspacioCalculadora;
using EspacioOperacion;
double termino;
int opcion;
string? linea;
Calculadora calcular = new Calculadora();
do
{
    linea = Console.ReadLine();
    if (int.TryParse(linea, out opcion))
        Console.WriteLine("opciones a elegir\n\t1.Sumar\n\t2.Restar\n\t3.Multiplicar\n\t4.Dividir\n\t5.Limpiar\n\t6.Mostrar historial\n\t7.Salir\nEscriba aca la opcion");
    {
        Console.WriteLine("Ingrese un valor para operar");
        linea = Console.ReadLine();
        if (double.TryParse(linea, out termino))
        {
            switch (opcion)
            {
                case 1:
                    calcular.Sumar(termino);
                    break;
                case 2:
                    calcular.Restar(termino);
                    break;
                case 3:
                    calcular.Multiplicar(termino);
                    break;
                case 4:
                    calcular.Dividir(termino);
                    break;
                case 5:
                    calcular.Limpiar();
                    break;
                case 6:
                    Console.WriteLine("Historial de operaciones");
                    foreach (Operacion operacionIndividual in calcular.HistorialOperaciones)
                    {
                        Console.WriteLine(operacionIndividual.ToString());
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
} while (opcion != 7);