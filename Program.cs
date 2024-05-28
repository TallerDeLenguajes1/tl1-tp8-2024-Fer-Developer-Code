using espacioTareas;
using EspacioEstado;
Random random = new Random();
int cantTareas = random.Next(1, 8);

List<Tarea> ListaTareasPendientes = new List<Tarea>();
List<Tarea> ListaTareasRealizadas = new List<Tarea>();

for (int i = 0; i < cantTareas; i++)
{
    int tiempoDuracion = random.Next(1, 50);
    Tarea tareaPendiente = new Tarea(i + 1, $"Tarea numero: {i + 1}", tiempoDuracion, EstadoTarea.Pendiente);
    ListaTareasPendientes.Add(tareaPendiente);
}

mostrarPendientes(ListaTareasPendientes);

static void mostrarPendientes(List<Tarea> ListaTareasPendientes)
{
    foreach (Tarea tarea in ListaTareasPendientes)
    {
        Console.WriteLine($"ID: {tarea.TareaID}, Descripcion: {tarea.Descripcion}, Duracion: {tarea.Duracion}, Estado: {tarea.EstadoTarea}");
    }
}

static void mostrarRealizadas(List<Tarea> ListaTareasRealizadas)
{
    foreach (Tarea tarea in ListaTareasRealizadas)
    {
        Console.WriteLine($"ID: {tarea.TareaID}, Descripcion: {tarea.Descripcion}, Duracion: {tarea.Duracion}");
    }
}