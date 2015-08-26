using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_08_26
{
    class Neumatico
    {
        public string marca;
        public long cambioKm;  //Cada cuanto se tiene q cambiar
        private long instalacionKm; //Cuando se Instalo


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
