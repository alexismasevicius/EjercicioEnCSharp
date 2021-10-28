using System;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pers = new Persona("Alexis", "Masevicius");

            Persona.GuardarJsonConExcepcion(pers);
            Persona.LeerJsonOk("");
            Persona.LeerJsonOk(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio57\serializacionJsonVacia.txt");
            Persona.LeerJsonOk(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio57\lalala.txt");
            Persona.LeerJsonOk(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\WDAWSADDSADADSDSADFSAF\lalala.txt");
            Persona.GuardarJsonOk(pers);
            Persona pers2 = Persona.LeerJsonOk(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio57\serializacionJson.txt");
            Persona pers3 = Persona.LeerXML(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio57\serializacionXML.xml");

            Persona.GuardarXML(pers2);


            Console.WriteLine( $"{pers2.ToString()}"  );
            Console.WriteLine($"{pers3.ToString()}");




        }
    }
}
