using System;

namespace nombre
{

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
