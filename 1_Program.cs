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
           /* Vehiculo MiAuto = new Vehiculo();

            //MiAuto.MotorDelAuto = new Motor();

            MiAuto.AgregarRuedas(new Neumatico(MiAuto.getterKMrecorridos()), new Neumatico(MiAuto.getterKMrecorridos()), new Neumatico(MiAuto.getterKMrecorridos()), new Neumatico(MiAuto.getterKMrecorridos()));
            */

            Usuario U1 = new Usuario("juan");
            Usuario U2;
            U2 = U1;
            //U2 = null;
            U2.nombre = "Maria";
           
            Console.WriteLine(U1.nombre);
            Console.ReadKey();

        }
    }
}
