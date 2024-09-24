using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Moto
    {
        public readonly string Marca;
        public readonly int Modelo;
        public readonly double ValorFabricacion;

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public string VerDescripcion()
        {
            return $"Vehiculo: Marca: {Marca}, Modelo: {Modelo}, Valor Fabricación: $ {ValorFabricacion}";
        }
    }
}
