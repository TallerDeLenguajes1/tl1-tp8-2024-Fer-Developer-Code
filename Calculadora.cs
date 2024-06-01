using EspacioOperacion;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        private List<Operacion> operaciones = new List<Operacion>();
        private double dato;
        private double resultadoAnterior;
        public List<Operacion> HistorialOperaciones { get => operaciones; }
        public double Resultado { get => dato; }

        public void Sumar(double termino)
        {
            resultadoAnterior = dato;
            dato += termino;
            HistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, espacioTipoOperacion.TipoOperacion.Suma));
        }
        public void Restar(double termino)
        {
            resultadoAnterior = dato;
            dato -= termino;
            HistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, espacioTipoOperacion.TipoOperacion.Resta));
        }
        public void Multiplicar(double termino)
        {
            resultadoAnterior = dato;
            dato *= termino;
            HistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, espacioTipoOperacion.TipoOperacion.Multiplicacion));
        }
        public void Dividir(double termino)
        {
            resultadoAnterior = dato;
            if (dato != 0)
            {
                dato /= termino;
                HistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, espacioTipoOperacion.TipoOperacion.Division));
            }
            else
            {

                Console.WriteLine("Inserte valores validos para la division");
            }
        }
        public void Limpiar()
        {
            resultadoAnterior = dato;
            dato = 0;
            HistorialOperaciones.Add(new Operacion(resultadoAnterior, dato, espacioTipoOperacion.TipoOperacion.Limpiar));
        }
    }
}