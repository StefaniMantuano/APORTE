using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Clientes

    {
        private string Nombres;
   
        private int Tickets;

        public Clientes(string Nombres, int Tickets)
        {
            this.Nombres = Nombres;
            this.Tickets = Tickets;
        }

        public string getNombres()
        {
            return Nombres;
        }

        public void setNombres(string Nombres)
        {
            this.Nombres = Nombres;
        }

        
        public int getTickets()
        {
            return Tickets;
        }
        public void setTickets(int Tickets)
        {
            this.Tickets = Tickets;
        }

        public void Mostrardatos()
        {
            {
                Console.WriteLine("Nombres del cliente:  (0) ,Tickets:      (1)", Nombres , Tickets);   
            }
        }
    }      
}
