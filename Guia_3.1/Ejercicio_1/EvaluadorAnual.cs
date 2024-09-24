using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class EvaluadorAnual : Evaluador
    {
        public double TasaDepreciacion { get; set; }

        public EvaluadorAnual(Moto vehiculo, int añoACalcular, double tasaDepreciacion):base(vehiculo, añoACalcular)
        {
            TasaDepreciacion = tasaDepreciacion;
        }
        public override double CalcularDepreciacion()
        {
            return vehiculo.ValorFabricacion * Math.Pow((1 - TasaDepreciacion), AñoACalcular);
        }
        public override string VerDescripcion()
        {
            return $@"{base.VerDescripcion()}
Tipo de evaluación anual, Monto: {CalcularDepreciacion()}";
        }
    }
}
