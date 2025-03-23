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

            Computadora c1 = new Computadora("HP", "INTEL", 16);
            c1.encenderse();
            c1.apagarse();

        }

        class Auto {
            public string color;
            public int anio;
            public int cant_ruedas;
            /*constructor*/
            public Auto(string color, int anio, int cant_ruedas)
            {
                this.color = color;
                this.anio = anio;
                this.anio = cant_ruedas;

               
            }
            /*Metodos*/
            public void avanzar()
            {
                Console.WriteLine("El auto avanzo");
            }

            public void detenerse()
            {
                Console.WriteLine("El auto se detuvo!");
            }

        }
        class Computadora
        {
            public string marca;
            public string procesador;
            public int memoria_ram;

            /*Metodos*/
            public void encenderse()
            {
                Console.WriteLine("La computadora encendio");
            }
            public void apagarse()
            {
                Console.WriteLine("La computadora se apago");
            }

            /*constructor*/
            public Computadora(string marca, string procesador, int memoria_ram)
            {
                this.marca = marca;
                this.procesador = procesador;
                this.memoria_ram = memoria_ram;


            }
        }
    }
}
