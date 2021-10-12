using System;


namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            string mostrar;
            Competencia compe = new Competencia(10,4,Competencia.TipoCompetencia.F1);
            AutoF1 auto1 = new AutoF1(2, "Ferrari",100);
            AutoF1 auto2 = new AutoF1(6, "McLaren",120);
            AutoF1 auto3 = new AutoF1(22, "Mercedes",150);
            AutoF1 auto4 = new AutoF1(41, "Red Bull",30);
            AutoF1 auto5 = new AutoF1(10, "Aston Martin",50);
            Competencia compeMoto = new Competencia(10, 4, Competencia.TipoCompetencia.MotoCross);


            if (compe + auto1)
            {
                Console.WriteLine("Entro....");
                mostrar=compe.MostarDatosComp();
                Console.WriteLine($"{mostrar}");
            }

            if (compe + auto2)
            {
                
                mostrar = compe.MostarDatosComp();
                Console.WriteLine($"{mostrar}");
            }
            if (compe + auto3)
            {

                mostrar = compe.MostarDatosComp();
                Console.WriteLine($"{mostrar}");
            }

            if (compe + auto4)
            {

                mostrar = compe.MostarDatosComp();
                Console.WriteLine($"{mostrar}");
            }
            

            if (compe + auto5)
            {

                mostrar = compe.MostarDatosComp();
                Console.WriteLine($"{mostrar}");
            }



        }
    }
}
