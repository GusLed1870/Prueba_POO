using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Construyendo un auto");
            Auto a1 = new Auto("Rojo",5212,4);
            a1.avanzar();
            a1.detenerse();

        }

        class Auto {
            public string color;
            public int anio;
            public int cant_ruedas;
            /*Metodos*/
            public Auto(string color, int anio, int cant_ruedas)
            {
                this.color = color;
                this.anio = anio;
                this.anio = cant_ruedas;


            }
            public void avanzar()
            {
                Console.WriteLine("El auto avanzo");
            }

            public void detenerse()
            {
                Console.WriteLine("El auto se detuvo");
            }

        }
    }
}
