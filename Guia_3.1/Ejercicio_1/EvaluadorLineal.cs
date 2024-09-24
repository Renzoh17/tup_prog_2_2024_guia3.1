using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class EvaluadorLineal : Evaluador
    {
        public int VidaUtil { get; set; }

        public EvaluadorLineal(Moto vehiculo, int añoACalcular, int vidaUtil):base(vehiculo, añoACalcular)
        {
            VidaUtil = vidaUtil;
        }
        public override double CalcularDepreciacion()
        {
            return (vehiculo.ValorFabricacion - (vehiculo.ValorFabricacion * AñoACalcular / VidaUtil));
        }
        public override string VerDescripcion()
        {
            return $@"{base.VerDescripcion()}
Tipo de evaluación lineal, Monto: {CalcularDepreciacion()}";
        }
    }
}
