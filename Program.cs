using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes();
            cliente.getNombres();
            cliente.setNombres("Stefania Mantuano");
            Console.WriteLine("Bienvenido  ", cliente.getNombres());
            Películas pelicula = new Películas();
            pelicula.Escogerpelicula();
            AperitivosAccesorios aperitivos =  new AperitivosAccesorios();
            aperitivos.AperitivoChocolate();
            Sala sala = new Sala();
            Console.WriteLine("Usted fue asiganado a la sala (0) su asiento es el numero (1)");




        }
    }
}
