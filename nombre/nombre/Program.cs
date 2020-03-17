using System;

namespace nombre
{

    public class Persona
    {
        public string Nombre;
        public string Apellido;

        public void Lanzar()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(0, 3));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Bob";
            persona.Apellido = "Kunga";
            persona.Lanzar();

        }
    }

}
