namespace EspacioOperacion
{
    public class TipoOperacion{
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion? operacion;
        public double Resultado{
            get{
                return resultadoAnterior;
            }
        }
        public double NuevoValor{
            get{
                return nuevoValor;
            }
        }
    }
}