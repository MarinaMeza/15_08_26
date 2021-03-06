﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_08_26
{
    class Vehiculo
    {
        public string marca;
        public long _KilometrosRecorridos;
        private Motor MotorDelAuto;
        private Neumatico Rueda1;
        private Neumatico Rueda2;
        private Neumatico Rueda3;
        private Neumatico Rueda4;
        public string patente;
        private static int contadorDeVehiculos;
        private static DateTime fecha;

        /// <summary>
        /// modificadores de acceso no estan permiitdos en constructores estaticos
        /// los constructores estaticos no deben tener parametros
        /// son privados
        /// el constructor estatico unicamente ve metodos o constructores estaticos
        /// </summary>
        static Vehiculo()
        {
            Vehiculo.fecha = DateTime.Now;
            Vehiculo.contadorDeVehiculos = 0;
        }

        public long getterKMrecorridos()
        {

            return this._KilometrosRecorridos;
        }

        public  Vehiculo()
        {
            this.MotorDelAuto = new Motor();
            this.marca = "Audi";
            this._KilometrosRecorridos = 0;
            Vehiculo.contador();
        }

        public static void contador()
        {
            Vehiculo.contadorDeVehiculos++;
        }

        public Vehiculo(string marca): this()
        {
            this.marca = marca;
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

        public static bool CompararVehiculo(Vehiculo auto1, Vehiculo auto2)
        {
            if (auto1.patente == auto2.patente)
                return true;
            return false;
        }

        public static bool operator ==(Vehiculo auto1, Vehiculo auto2)
        {
            if (auto1.patente == auto2.patente)
                return true;
            return false;
        }

        public static bool operator !=(Vehiculo auto1, Vehiculo auto2)
        {
            return !(auto1 == auto2);
        }
        
        /// <summary>
        /// Suma los kilometros de los vehiculos retornando solamente la suma si tienen patentes distintas.
        /// De lo contrario, retornará 0
        /// </summary>
        /// <param name="auto1"></param>
        /// <param name="auto2"></param>
        public static long SumarVehiculo(Vehiculo auto1, Vehiculo auto2)
        {
            if (auto1 != auto2)
            {
                return (auto1._KilometrosRecorridos + auto2._KilometrosRecorridos);
            }
            else
                return 0;
        }

        public static long operator +(Vehiculo auto1, Vehiculo auto2)
        {
            if (auto1 != auto2)
            {
                return (auto1._KilometrosRecorridos + auto2._KilometrosRecorridos);
            }
            else
                return 0;
        }
    
        
    }//fin Clase
}
 