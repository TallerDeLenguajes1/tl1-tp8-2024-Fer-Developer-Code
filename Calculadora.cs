using EspacioOperacion;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        private List<Operacion> Operaciones = new List<Operacion>();
        private double dato;

        public double Resultado { get => dato; }
        public List<Operacion> Operaciones1 { get => Operaciones; set => Operaciones = value; }

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