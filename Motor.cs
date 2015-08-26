using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_08_26
{
    class Motor
    {
        public string marca;
        public long serviceKm; //Cada cuanto hay q hacer el service

        public bool VerificarService(long KmRecorridos)
        {
            long lAux = KmRecorridos % this.serviceKm;
            if(lAux <= this.serviceKm - 10000)
            {
                Console.WriteLine("Tenes que hacer el service en " + lAux);
                return true;
            }
            return false;
        }
    }
}
