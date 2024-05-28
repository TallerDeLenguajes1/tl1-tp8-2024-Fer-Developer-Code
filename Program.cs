using espacioTareas;
Random random = new Random();
int cantTareas = random.Next(1, 8);

List<Tarea> ListaTareasPendientes = new List<Tarea>();
List<Tarea> ListaTareasRealizadas = new List<Tarea>();

for (int i = 0; i < cantTareas; i++)
{
    Tarea tareaPendiente = new Tarea();
    int tiempoDuracion = random.Next(1, 50);
    tareaPendiente.TareaID = i + 1;
    tareaPendiente.Descripcion = $"Esta es la tarea numero: {i+1}";
    tareaPendiente.Duracion = tiempoDuracion;
    ListaTareasPendientes.Add(tareaPendiente);
}

mostrarPendientes(ListaTareasPendientes);

static void mostrarPendientes(List<Tarea> ListaTareasPendientes){
    foreach (Tarea tarea in ListaTareasPendientes)
    {
        Console.WriteLine($"ID: {tarea.TareaID}, Descripcion: {tarea.Descripcion}, Duracion: {tarea.Duracion}");
    }
}

static void mostrarRealizadas(List<Tarea> ListaTareasRealizadas){
    foreach (Tarea tarea in ListaTareasRealizadas)
    {
        Console.WriteLine($"ID: {tarea.TareaID}, Descripcion: {tarea.Descripcion}, Duracion: {tarea.Duracion}");
    }
}