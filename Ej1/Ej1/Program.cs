using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Bienvenido a la papelería, ¿Cuántos paquetes de 500 hojas quieres?");
			int paquete = Convert.ToInt32(Console.ReadLine());
			float precio = 1;
			if (paquete < 200) precio = 4.5f;
			else if (200 <= paquete && paquete <= 500) precio = 3.75f;
			else if (paquete > 500) precio = 3.25f;
			else if(paquete <= 0) Console.WriteLine("¿Has venido a comprar o no?");
			float precio_final = paquete * precio;
			Console.WriteLine("El precio final es de " + precio_final + " euros.");
			Console.ReadKey();

		}
	}
}
