using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_08_26
{
    /// <summary>
    /// Se debe realizar un sistema que realize el control del estado de un vehiculo verificando el estado de los neumaticos
    /// y el motor por la cantidad de Km recorridos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
           Vehiculo MiAuto = new Vehiculo();
           MiAuto.MotorDelAuto = new Motor();
           MiAuto.Rueda1 = new Neumatico();
           MiAuto.Rueda2 = new Neumatico();
           MiAuto.Rueda3 = new Neumatico();
           MiAuto.Rueda4 = new Neumatico();

           MiAuto.marca = "Audi";
           MiAuto.KilometrosRecorridos = 0;

           MiAuto.MotorDelAuto.marca = "Audi";
           MiAuto.MotorDelAuto.serviceKm = 50000;           
           
           MiAuto.Rueda1.marca = "Audi";
           MiAuto.Rueda1.cambioKm = 25000;
           MiAuto.Rueda2.marca = "Audi";
           MiAuto.Rueda2.cambioKm = 25000;
           MiAuto.Rueda3.marca = "Audi";
           MiAuto.Rueda3.cambioKm = 25000;
           MiAuto.Rueda4.marca = "Audi";
           MiAuto.Rueda4.cambioKm = 25000;



        }
    }
}
