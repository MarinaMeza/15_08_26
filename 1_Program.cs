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

            Usuario U1 = new Usuario();
            Vehiculo auto1 = new Vehiculo();
            long SumaKM;
           
            U1.auto.patente = "213";
            auto1.patente = "013";

            U1.auto._KilometrosRecorridos = 50;
            auto1._KilometrosRecorridos = 100;

            if (auto1 == U1.auto)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            //SumaKM = Vehiculo.SumarVehiculo(auto1, U1.auto);
            SumaKM = auto1 + U1.auto;
            Console.WriteLine(SumaKM);

            Console.ReadKey();
        }
    }
}