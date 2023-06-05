using System;

namespace VisitorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("José", 1);
            Node n2 = new Node("Ana", 2);
            Node n3 = new Node("Pedro", 3);
            Node n4 = new Node("Marcela", 4);
            Node n5 = new Node("Fernando", 5);
            Node n6 = new Node("Rafaella", 6);
            Node n7 = new Node("Javier", 7);

            
            

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            SumaEdadesContent SumaEdades = new SumaEdadesContent(n1);
            Console.WriteLine(SumaEdades.GetEdad());

            HijoMayorContent HijoMayor = new HijoMayorContent(n1);
            Console.WriteLine(HijoMayor.GetPersona().Nombre);

            MayorNombreContent MayorNombre = new MayorNombreContent(n1);
            Console.WriteLine(MayorNombre.GetPersona().Nombre);

            // visitar el árbol aquí
        }
    }
}
