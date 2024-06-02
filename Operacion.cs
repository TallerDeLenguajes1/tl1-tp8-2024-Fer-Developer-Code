using espacioTipoOperacion;
namespace EspacioOperacion
{
    public class Operacion
    {
        private DateTime horaYMinutos;
        private double resultadoAnterior;
        private double resultadoActual;
        private double nuevoValor;
        private TipoOperacion operacion;
        public Operacion(double resultadoAnterior, double resultadoActual, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.resultadoActual = resultadoActual;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
            horaYMinutos = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
        }
        public double Resultado
        {
            get
            {
                return resultadoAnterior;
            }
        }
        public double NuevoValor
        {
            get
            {
                return nuevoValor;
            }
        }
        public TipoOperacion OperacionHecha
        {
            get
            {
                return operacion;
            }
        }

        public DateTime HoraYMinutos { get => horaYMinutos; }
        public double ResultadoActual { get => resultadoActual; }
    }
}