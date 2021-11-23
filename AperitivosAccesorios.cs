using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class AperitivosAccesorios : Sala
    {
        private int Chocolate;

        public AperitivosAccesorios(string Nombres, int Tickets, int Aladdin, int Avengers, int Pikachu, int JohnWick3, int NumeroAsientos, int NuevaSala, int Chocolate) :
            base(Nombres, Tickets, Aladdin, Avengers, Pikachu, JohnWick3,NumeroAsientos, NuevaSala)

        {
            this.Chocolate = Chocolate;
            
        }

        public int getChocolate()
        {

            return Chocolate;
        }
        public void setChocolate(int Chocolate)
        {
            this.Chocolate = Chocolate;
        }
         
        public void AperitivoChocolate()
        {
            Console.WriteLine("Entrega del aperitivo por la compra de boleto");
        }
    }
}