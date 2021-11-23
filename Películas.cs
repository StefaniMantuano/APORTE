using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Películas : Clientes
    {

        private int Aladdin;
        private int Avengers;
        private int Pikachu;
        private int JohnWick3;

        public Películas(string Nombres, int Tickets, int Aladdin, int Avengers, int Pikachu, int JohnWick3) :
            base(Nombres, Tickets)

        {
            this.Aladdin = Aladdin;
            this.Avengers = Avengers;
            this.Pikachu = Pikachu;
            this.JohnWick3 = JohnWick3;
        }


        public int getAladdin()
        {

            return Aladdin;
        }
        public void setAladdin(int Aladdin)
        {
            this.Aladdin = Aladdin;
        }

        public int getAvengers()
        {

            return Avengers;
        }
        public void setAvengers(int Avengers)
        {
            this.Avengers = Avengers;
        }


        public int getPikachu()
        {

            return Pikachu;
        }
        public void setPikachu(int Pikachu)
        {
            this.Pikachu = Pikachu;
        }

        public int getJohnWick3()
        {

            return JohnWick3;
        }
        public void setJohnWick3(int JohnWick3)
        {
            this.JohnWick3 = JohnWick3;
        }

        public void Escogerpelicula()
        {
                int precio_JohnWick3 = 0;
                int precio_Aladdin = 0;
                int precio_Avengers = 0;
                int precio_Pikachu=0;
                int pelicula;

                Console.Clear();
                Console.WriteLine("Elija la pelicula: \nJonhWick3-----1 \nAladdin-----2 \nAvengers-----3\nPikachu-----4");
                pelicula  = int.Parse(Console.ReadLine());

            //si es JohnWick3
            if (pelicula == 1)
            {

                Console.Write("Ingrese cantidad de compra: ");
                int cantidad_JohnWick3 = int.Parse(Console.ReadLine());

                precio_JohnWick3 = 5;
                int calculo_Wick3 = precio_JohnWick3 * cantidad_JohnWick3;


                Console.WriteLine("Usted esta comprando " + cantidad_JohnWick3 + " boletos para la pelicula de JohnWick3");
                Console.WriteLine("Con un total de: $" + calculo_Wick3);


            }
            //si es Aladdin
            else if (pelicula == 2)
            {
                Console.Write("Ingrese cantidad de compra: ");
                int cantidad_Aladdin = int.Parse(Console.ReadLine());

                //precio 
                precio_Aladdin = 4;

                //calculo 
                int calculo_Aladdin = precio_Aladdin * cantidad_Aladdin;

                //mensaje de la compra
                Console.WriteLine("Usted esta comprando " + cantidad_Aladdin + " boletos para la pelicula de Aladdin");
                Console.WriteLine("Con un total de: $" + calculo_Aladdin);


            }
            //si es Avengers
            else
            {

                Console.Write("Ingrese cantidad de compra: ");
                int cantidad_Avengers = int.Parse(Console.ReadLine());

                //precio 
                precio_Avengers = 6;

                //calculo 
                int calculo_Avengers = precio_Avengers * cantidad_Avengers;

                //mensaje de la compra
                Console.WriteLine("Usted esta comprando " + cantidad_Avengers + " boletos para la pelicula Avengers");
                Console.WriteLine("Con un total de: $" + calculo_Avengers);

            }
             //
            if (pelicula == 4)
            {
                 Console.Write("Ingrese cantidad de compra: ");
                 int cantidad_Pikachu = int.Parse(Console.ReadLine());

                  //precio 
                  precio_Pikachu = 7;

                 //calculo 
                  int calculo_Pikachu = precio_Pikachu * cantidad_Pikachu;

                 //mensaje de la compra
                  Console.WriteLine("Usted esta comprando " + cantidad_Pikachu + " boletos para la pelicula Pikachu");
                  Console.WriteLine("Con un total de: $" + calculo_Pikachu);
            }

        }
    }
}
