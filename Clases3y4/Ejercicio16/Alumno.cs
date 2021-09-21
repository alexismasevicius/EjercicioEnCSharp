using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        private int nota1;
        private int nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public string legajo;

        public Alumno(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public int GetNota1()
        {
            return this.nota1;
        }
        private void SetNota1(int nuevaNota)
        {
            nota1 = nuevaNota;
        }
        public int GetNota2()
        {
            return this.nota2;
        }
        private void SetNota2(int nuevaNota)
        {
            nota2 = nuevaNota;
        }
        public float GetNotaFinal()
        {
            return this.notaFinal;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetLegajo()
        {
            return this.legajo;
        }

        public void Estudiar(int nota1, int nota2)
        {
            SetNota1(nota1);
            SetNota2(nota2);
        }

        public void CalcularFinal()
        {
            Random rnd = new Random();

            if(this.nota1>=4 && this.nota2>=4)
            {
                this.notaFinal = rnd.Next(10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            string resultado;

            if(this.notaFinal==-1)
            {
                resultado = $"El alumno {this.apellido} fue desaprobado";
            }
            else
            {
                resultado = $"La nota del alumno {this.nombre} {this.apellido} es {this.notaFinal}";
            }

            return resultado;
        }
    }
}
