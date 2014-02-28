/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 28/02/2014
 * Time: 11:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	class Program
	{
		
		public Program(){
	      
		}
		
		public static void Main(string[] args)
		{
			
		    string lapiz;
		    string borrador;
		    string cuaderno;
		 
		    double xx;
		    double yy;
		    double zz;
		    double total;
		      
			Console.WriteLine("Introduce el precio para lapiz");
			lapiz=Console.ReadLine();
			Console.WriteLine("Introduce el precio para borrador");
			borrador=Console.ReadLine();
			Console.WriteLine("Introduce el precio para cuarderno");
			cuaderno=Console.ReadLine();
			
			float x = float.Parse(lapiz);
			float y = float.Parse(borrador);
			float z = float.Parse(cuaderno);
			
			xx = x * 1.16;
			yy = y * 1.16;
			zz = z * 1.16;
			
			total = xx + yy + zz;
			
			Console.WriteLine("lapiz: " + xx);
			Console.WriteLine("borrador: " + yy);
			Console.WriteLine("cuarderno: " + zz);
            Console.WriteLine("El total de todo es de: " + total);
			
			Console.ReadKey(true);
		}
	}
}