using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string firstname = "Enrique";
            String lastname = "Marenco";
            int edad = 27;
            //Concatenación de variables
            var name = firstname + " " + lastname;
            //Imprimir variables dentro del texto
            Console.WriteLine("Su nombre es: {1} y su edad es: {0}", edad, name);
        }
    }
}
