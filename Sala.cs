using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Sala : Películas
    {
        private int NumeroAsientos;
        private int NuevaSala;

        public Sala(string Nombres, int Tickets, int Aladdin, int Avengers, int Pikachu, int JohnWick3, int NumeroAsientos, int NuevaSala) :
            base(Nombres,Tickets, Aladdin, Avengers, Pikachu, JohnWick3)

        {
            this.NumeroAsientos = NumeroAsientos;
            this.NuevaSala = NuevaSala;
        }
        public int getNumeroAsientos()
        {

            return NumeroAsientos;
        }
        public void setNumeroAsientos(int NumeroAsientos)
        {
            this.NumeroAsientos = NumeroAsientos;
        }

        public int getNuevaSala()
        {

            return NuevaSala;
        }
        public void setNuevasala(int NuevaSala)
        {
            this.NuevaSala = NuevaSala;
        }

        public void MostrarAsientos()

        {
            Console.WriteLine("Numero de asiento: " + NumeroAsientos);
            Console.WriteLine("Numero de sala:  " + NuevaSala);
                
        }
    }
}