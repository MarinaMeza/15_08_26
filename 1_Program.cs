﻿using System;
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

           MiAuto.marca = "Audi";

           MiAuto.MotorDelAuto.marca = "Audi";
           MiAuto.MotorDelAuto.serviceKm = 50000;           
           
           MiAuto.Rueda1.marca = "Audi";
           MiAuto.Rueda1.instalacionKm = 25000;
           MiAuto.Rueda2.marca = "Audi";
           MiAuto.Rueda2.instalacionKm = 25000;
           MiAuto.Rueda3.marca = "Audi";
           MiAuto.Rueda3.instalacionKm = 25000;
           MiAuto.Rueda4.marca = "Audi";
           MiAuto.Rueda4.instalacionKm = 25000;



        }
    }
}
