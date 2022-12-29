using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Carro

    {
        //instancia
        internal Carro(string v)
        {
            Console.WriteLine("Instanciando un carro");
          //  _marca = String.Empty;
            _marca = "";
            ConteonInstancias++;

        }

        public Carro()
        {
        }

        public static int ConteonInstancias { get; set; }


        //por convecion los campos empiezan con guion bajo

        private string _marca;
        private int _año;
        private int VelocidadMaxima => 120;

        //manera 1 de declarar los sey y get
        internal string Marca
        {
            get { return _marca; }
            set { _marca = value; }

        }
        //manera 2 de declarar los set y get
        internal int Año { get; set; }


        internal int velocidad { get; private set; } = 12;

        //instanciar clase


        internal void Acelerar()
        {

            if (velocidad >= VelocidadMaxima) 
            { 
                Console.WriteLine("la velocidad maxima alcansada"); 
                return; 
            
            
            
            }
            velocidad++;
            
        }

        internal void Detener() => velocidad = 0;


        internal void Acelerar(int incremento)
        {

            if (velocidad >= VelocidadMaxima)
            {
                Console.WriteLine("la velocidad maxima alcansada");
                return;



            } else if (velocidad + incremento > VelocidadMaxima)
            {

                incremento = VelocidadMaxima - velocidad;
            }
            velocidad += incremento;

        }
    }
}
