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
        private Motor MotorDelAuto;
        private Neumatico Rueda1;
        private Neumatico Rueda2;
        private Neumatico Rueda3;
        private Neumatico Rueda4;

        public long getterKMrecorridos()
        {

            return this._KilometrosRecorridos;
        }

        public  Vehiculo()
        {
            this.MotorDelAuto = new Motor();
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


        public void AgregarRuedas(Neumatico fRueda1, Neumatico fRueda2, Neumatico fRueda3, Neumatico fRueda4)
        {
            this.Rueda1 = fRueda1;
            this.Rueda2 = fRueda2;
            this.Rueda3 = fRueda3;
            this.Rueda4 = fRueda4;
        }


        

    }//fin Clase
}
