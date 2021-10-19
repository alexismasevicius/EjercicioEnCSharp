using System;
using Ejercicio47;

namespace Ejercicio47Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipo> torneo1 = new Torneo<Equipo>("Torneo Uno");
            Torneo<Equipo> torneo2 = new Torneo<Equipo>("Torneo Dos");

            EquipoBasquet basquet1 = new EquipoBasquet("Nuggets", DateTime.Now);
            EquipoBasquet basquet2 = new EquipoBasquet("Heat", DateTime.Now);
            EquipoBasquet basquet3 = new EquipoBasquet("Spurs", DateTime.Now);

            EquipoFutbol futbol1 = new EquipoFutbol("Machester", DateTime.Now);
            EquipoFutbol futbol2 = new EquipoFutbol("Barcelona", DateTime.Now);
            EquipoFutbol futbol3 = new EquipoFutbol("Milan", DateTime.Now);

            if(torneo1 + futbol1)
            if (torneo1 + futbol2)
            if (torneo1 + futbol3)
            if (torneo2 + basquet1)
            if (torneo2 + basquet2)
            if (torneo2 + basquet3)
            //Mostrar

            Console.WriteLine(torneo1.Mostrar());
            Console.WriteLine(torneo2.Mostrar());

            Console.WriteLine(torneo1.JugarPartido);
            Console.WriteLine(torneo1.JugarPartido);
            Console.WriteLine(torneo2.JugarPartido);

        }
    }
}
