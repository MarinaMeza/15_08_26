using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_08_26
{
    class Neumatico
    {
        private string marca;
        public long cambioKm;  //Cada cuanto se tiene q cambiar
        public long instalacionKm; //Cuando se Instalo

        // CONSTRUCTOR:
         //Los Constructores no retorna nada "void"
         //Pede ser publico o privado
         //se llama igual q la clase

        public void Neumatico()
        {
            this.cambioKm = 25000;
            this.marca = "Pireli";
        }

        public void set(long KmInstalacion)
        {
            this.instalacionKm = KmInstalacion;
        }

        public bool NecesitaCambio(long KmRecorridos)
        {
            if (KmRecorridos - this.instalacionKm > this.cambioKm)
                return true;
            return false;
        }
    }
}
