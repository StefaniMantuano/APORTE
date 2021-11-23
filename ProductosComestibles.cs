using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ProductosComestibles : Sala
    {
        private int Bebidas;
        private int Canguil;
        private int HotDogs;

        public ProductosComestibles(string Nombres, int Tickets, int Aladdin, int Avengers, int Pikachu, int JohnWick3, int NumeroAsientos, int NuevaSala, int Bebidas, int Canguil, int HotDogs):
            base (Nombres, Tickets, Aladdin, Avengers, Pikachu, JohnWick3, NumeroAsientos, NuevaSala)

        {
            this.Bebidas = Bebidas;
            this.Canguil = Canguil;
            this.HotDogs = HotDogs;
        }
        public int getBebidas()
        {

            return Bebidas;
        }
        public void setBebidas(int Bebidas)
        {
            this.Bebidas = Bebidas;
        }

        public int getCanguil()
        {

            return Canguil;
        }
        public void setCanguil(int Canguil)
        {
            this.Canguil = Canguil;
        }

        public int getHotDogs()
        {

            return HotDogs;
        }
        public void setHotDogs(int HotDogs)
        {
            this.HotDogs= HotDogs;
        }

         public void EscogerProducto()

        {
            int consumir;
            Console.WriteLine("Elija el producto a consumir:  \nBebidas-----1 \nCanguil-----2 \nHotDogs-----3");
            consumir = int.Parse(Console.ReadLine());

            if (consumir ==1)
            {
                Console.WriteLine("Ha seleccionado bebidas");
            }
            else if (consumir ==2)
            {
                Console.WriteLine("Ha seleccionado canguil");
            }
            else if (consumir ==3)
            {
                Console.WriteLine("Ha seleccionado HotDogs");
            }
        }
    }
}
