using espacioTipoOperacion;
namespace EspacioOperacion
{
    public class Operacion{
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion){
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }
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
        public TipoOperacion OperacionHecha{
            get{
                return operacion;
            }
        }
    }
}