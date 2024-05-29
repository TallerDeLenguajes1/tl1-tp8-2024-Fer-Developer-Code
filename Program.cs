using espacioTareas;
using EspacioEstado;
Random random = new Random();
int cantTareas = random.Next(1, 8);
int opcion;
int idTareaBuscada;
string? linea;
bool hayoTarea = true;

List<Tarea> ListaTareasPendientes = new List<Tarea>();
List<Tarea> ListaTareasRealizadas = new List<Tarea>();

asignarTareas(random, cantTareas, ListaTareasPendientes);
mostrarPendientes(ListaTareasPendientes);

do
{
    Console.WriteLine("¿Desea empezar a mover las tareas pendientes a realizadas?\nInserte 1 para si, 2 para no");
    linea = Console.ReadLine();
    if (int.TryParse(linea, out opcion))
    {
        if (opcion == 1)
        {
            Console.WriteLine("Inserte el ID de la tarea que desea hayar");
            linea = Console.ReadLine();
            if (int.TryParse(linea, out idTareaBuscada))
            {
                hayoTarea = buscarPorId(idTareaBuscada, hayoTarea, ListaTareasPendientes, ListaTareasRealizadas);
                if (!hayoTarea)
                {
                    Console.WriteLine("No se encontro ninguna tarea con ese ID\nDesea buscarlas por descripcion?\n1 para si 2 para no");
                    linea = Console.ReadLine();
                    if (int.TryParse(linea, out opcion))
                    {
                        if (opcion == 1)
                        {
                            Console.WriteLine("Inserte la descripcion de la tarea que desea buscar");
                            linea = Console.ReadLine();
                            hayoTarea = mostarPorDescripcion(linea, hayoTarea, ListaTareasPendientes);
                            if (!hayoTarea)
                            {
                                Console.WriteLine("No se encontro ninguna tarea con esa descripcion");
                            }
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Volviendo al inicio del programa");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inserte un numero valido para operar");
                    }
                }
            }
            else
            {
                Console.WriteLine("Inserte un numero valido para operar");
            }
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Gracias por usar el gestor de tareas");
            break;
        }
        else
        {
            Console.WriteLine("Inserte un numero valido para operar");
        }
    }
    else
    {
        Console.WriteLine("Inserte 1 para si, 2 para no");
    }
} while (opcion != 2);

mostrarPendientes(ListaTareasPendientes);
mostrarRealizadas(ListaTareasRealizadas);

static void mostrarPendientes(List<Tarea> ListaTareasPendientes)
{
    foreach (Tarea tarea in ListaTareasPendientes)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"\tID: {tarea.TareaID}, Descripcion: {tarea.Descripcion}, Duracion: {tarea.Duracion}, Estado: {tarea.EstadoActual}.");
        Console.WriteLine("----------------------------------------------------------------");
    }
}

static void mostrarRealizadas(List<Tarea> ListaTareasRealizadas)
{
    foreach (Tarea tarea in ListaTareasRealizadas)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"ID: {tarea.TareaID}, Descripcion: {tarea.Descripcion}, Duracion: {tarea.Duracion}, Estado: {tarea.EstadoActual}.");
        Console.WriteLine("----------------------------------------------------------------");
    }
}

static void asignarTareas(Random random, int cantTareas, List<Tarea> ListaTareasPendientes)
{
    for (int i = 0; i < cantTareas; i++)
    {
        int tiempoDuracion = random.Next(201, 501);
        Tarea tareaPendiente = new Tarea(i + 1, $"Tarea numero: {i + 1}", tiempoDuracion, EstadoTarea.Pendiente);
        ListaTareasPendientes.Add(tareaPendiente);
    }
}

static bool buscarPorId(int idTareaBuscada, bool hayoTarea, List<Tarea> ListaTareasPendientes, List<Tarea> ListaTareasRealizadas)
{
    foreach (Tarea tareaBuscada in ListaTareasPendientes)
    {
        if (idTareaBuscada == tareaBuscada.TareaID)
        {
            hayoTarea = true;
            var auxTarea = tareaBuscada;
            auxTarea.EstadoActual = EstadoTarea.Realizada;
            ListaTareasRealizadas.Add(auxTarea);
            ListaTareasPendientes.Remove(tareaBuscada);
            Console.WriteLine("Tarea movida con exito");
            break;
        }
    }

    return hayoTarea;
}

static bool mostarPorDescripcion(string? linea, bool hayoTarea, List<Tarea> ListaTareasPendientes)
{
    foreach (Tarea tareaBuscada in ListaTareasPendientes)
    {
        if (linea != null && tareaBuscada.Descripcion.Contains(linea))
        {
            hayoTarea = true;
            Console.WriteLine($"\tID: {tareaBuscada.TareaID}, Descripcion: {tareaBuscada.Descripcion}, Duracion: {tareaBuscada.Duracion}, Estado: {tareaBuscada.EstadoActual}.");
        }
    }

    return hayoTarea;
}