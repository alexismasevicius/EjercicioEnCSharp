using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;

            Alumno primerAlumno = new Alumno("Masevicius", "Alexis","25644");
            Alumno segundoAlumno = new Alumno("Benitezx", "Sofia", "24544");
            Alumno tercerAlumno = new Alumno("Perexz", "Juan", "25554");

            primerAlumno.Estudiar(7, 1);
            segundoAlumno.Estudiar(4, 10);
            tercerAlumno.Estudiar(4, 5);

            primerAlumno.CalcularFinal();
            segundoAlumno.CalcularFinal();
            tercerAlumno.CalcularFinal();

            resultado = primerAlumno.Mostrar();
            Console.WriteLine($"{resultado}");
            resultado = segundoAlumno.Mostrar();
            Console.WriteLine($"{resultado}");
            resultado = tercerAlumno.Mostrar();
            Console.WriteLine($"{resultado}");
        }
    }
}
