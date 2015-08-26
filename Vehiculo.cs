using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_08_26
{
    class Vehiculo
    {
        public string marca;
        private long _KilometrosRecorridos;
        public Motor MotorDelAuto;
        public Neumatico Rueda1;
        public Neumatico Rueda2;
        public Neumatico Rueda3;
        public Neumatico Rueda4;

        public void Vehiculo()
        {
            this.marca = "Audi";
            this._KilometrosRecorridos = 0;
        }

        public void Andar(long KmRecorridos)
        {
           this._KilometrosRecorridos = this._KilometrosRecorridos + KmRecorridos;

           if (this.MotorDelAuto.VerificarService(this._KilometrosRecorridos))
           {
               Console.WriteLine("Necesita Service");
           }

           if (this.Rueda1.NecesitaCambio(this._KilometrosRecorridos))
           {
               Console.WriteLine("Necesita Cambio");
           }
           if (this.Rueda2.NecesitaCambio(this._KilometrosRecorridos))
           {
               Console.WriteLine("Necesita Cambio");
           }
           if (this.Rueda3.NecesitaCambio(this._KilometrosRecorridos))
           {
               Console.WriteLine("Necesita Cambio");
           }
           if (this.Rueda4.NecesitaCambio(this._KilometrosRecorridos))
           {
               Console.WriteLine("Necesita Cambio");
           }
        }



        

    }
}
