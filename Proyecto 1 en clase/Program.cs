using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_en_clase
{
    internal class Program
    {

        public struct empleado
        {
            public int codigo;
            public string nombre;
            public float salario;
        }
            static void Main(string[] args)
        {

            // tipos de datos
            int num1, num2;
            short corto = 5660;
            num1 = 5877;
            float flotante = 3.14f;
            double doble = 15.2d;
            decimal deci = 15.15m;
            byte b = 25;
            long larga = 123456789132456;
            ulong ulargo = 56;
            Boolean boleano = false;
            char letra = 'a';
            string cadena = "hoy es lunes 18 de setiembre";

            //var // dinamic

            var variable = 15.25f;
            dynamic dinamica = 25.3f;
            dinamica = "nombre empleado";
            dinamica = true;
            dinamica = 'c';

            // arreglos
            int n = 4;
            string[] musico = new string[n];
            string[] temporal = new string[n];
            musico[0] = "carlos";
            musico[1] = "maria";
            musico[2] = "sofia";
            musico[3] = "eva";

            float[] salario = new float[5];

            for (int i = 0; i < salario.Length; i++)
            {
                Console.WriteLine("digite salario");
                salario[0] = float.Parse(Console.ReadLine());
            }

            if (true)
            {

            }
            while (true) { }
            do { } while (true);

            Console.WriteLine("listado de musicos");

            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);

            n = 20;
            temporal = new string[n];
            musico = temporal;
            musico = new string[n];

            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);


            Console.ReadLine();
            string[] nombres = new string[] {"ringo", "george", "paul", "john"};
            

            empleado emp;
            emp.codigo = 1;
            emp.nombre = "Gerardo";
            emp.salario = 560000;
        }
     }
}
