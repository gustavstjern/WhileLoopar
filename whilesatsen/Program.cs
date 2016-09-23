using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilesatsen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Önv1
            /*
            int x = 0;
            while (x++<100)
            {
                Console.Write(x  + " ");
            }
            */
            //Övn2
            /*
            int x = 0;
            string pass = ""; 
            while (pass != "dampbarn")
            {
                x++;
                Console.Write("Mata in ditt lösenord: ");
                pass = Console.ReadLine();
                if (pass == "dampbarn")
                {
                    Console.WriteLine("Korrekt lösenord!");
                }
                else if (pass != "dampbarn")
                {
                    Console.WriteLine("Fel lösenord!");
                    Console.WriteLine("Du har försökt {0} gånger",x);
                }
            }
            */
            //Övn3
            /*
            int i = 0;
            while (i++<100)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
            //Övn4
            /*
            int i = 10;
            while (i-->1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
            //Övn5
            /*
            int i = 1;
            while (++i>1)
            {
                Console.WriteLine("Anton e sämst");
            }
            */
            //Övn6
            /*
            Random rnd = new Random();
            int tal = rnd.Next(1, 101);
            int x =0;
            int y = 0;
            while (x != tal)
            {
                y++;
                Console.Write("Gissa ett tal mellan 1 och 100: ");
                x = int.Parse(Console.ReadLine());
                if (x>tal)
                {
                    Console.WriteLine("För högt!");
                }
                else if (x<tal)
                {
                    Console.WriteLine("För Lågt!");
                }
                else if (x==tal)
                {
                    Console.WriteLine("Grattis det tog dig {0} gissning(ar)", y);
                }
            }
            */
            //Övn7 
            /*
            int x = 0;
            int y = 1;
            while ((x + y)<1000000)
            {
                Console.Write((y = y + x) + " ");
                Console.Write((x = y + x) + " ");
            }
            */
            //Övn8
            Console.Write("Ange saldo på konto <kr>: ");
            int kr = int.Parse(Console.ReadLine());
            Console.Write("Ange ränta <%>: ");
            int rent = int.Parse(Console.ReadLine());
            Console.Write("Ange mål <kr>: ");
            int goal = int.Parse(Console.ReadLine());
            int y = 0;
            while (kr<goal)
            {
                y++;
                kr = kr * (100 / rent + 1);
                if (kr>goal)
                {
                    Console.WriteLine("Det tog {0} år innan saldot når {1}", y, kr); 
                }
            }

        }
    }
}
