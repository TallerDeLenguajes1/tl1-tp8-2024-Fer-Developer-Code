using EspacioEstado;

namespace espacioTareas
{
    public class Tarea()
    {
        private int tareaID;
        private string descripcion = "";
        private int duracion;
        private EstadoTarea Estado;

        public Tarea(int tareaID, string descripcion, int duracion, EstadoTarea estado)
        {
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
            EstadoTarea = estado;
        }

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public EstadoTarea EstadoTarea { get => Estado; set => Estado = value; }
    }
}