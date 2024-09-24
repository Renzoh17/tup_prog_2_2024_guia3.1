using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal abstract class Evaluador
    {
        protected int añoACalcular;
        public int AñoACalcular { get { return añoACalcular - vehiculo.Modelo; } }
        public Moto vehiculo;

        public Evaluador(Moto vehiculo, int añoACalcular)
        {
            this.añoACalcular = añoACalcular;
            this.vehiculo = vehiculo;
        }
        public abstract double CalcularDepreciacion();
        public virtual string VerDescripcion()
        {
            return vehiculo.VerDescripcion();
        } 
    }
}
