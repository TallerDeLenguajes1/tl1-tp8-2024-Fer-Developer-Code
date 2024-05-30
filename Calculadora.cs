using EspacioOperacion;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        List<Operacion> operacions = new List<Operacion>();
        private double dato;

        public double Resultado { get => dato; }

        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (dato != 0)
            {
                dato /= termino;
            }
            else
            {

                Console.WriteLine("Inserte valores validos para la division");
            }
        }
        public void Limpiar()
        {
            dato = 0;
        }
    }
}