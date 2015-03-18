/*
 * Created by SharpDevelop.
 * User: Claudia
 * Date: 11/03/2015
 * Time: 10:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
 
 namespace Practica_3
 {
 	class Program
 	{
 		private Hashtable tabla;
 		
 		public Program(){
 			tabla=new Hashtable();	
 		}
 		public void agregarAlumno(){
 			String nombre;
 			String codigo;
 			Console.Write("Nombre del alumno: ");
 			nombre=Console.ReadLine();
 			Console.Write("Codigo del alumno: ");
 			codigo=Console.ReadLine();
 			Alumno alumno=new Alumno(nombre,codigo);
 			tabla.Add(codigo,alumno);
 		}
 		public void verAlumnos(){
 			Console.WriteLine("\n****** Alumnos Registrados *******\n");
 			foreach ( string codigo in tabla.Keys){
 				try{
 					Object obj= tabla[codigo];
 					Alumno alumno= (Alumno) obj;
 					Console.WriteLine(alumno.getDatos());
 					
 				}catch(Exception e){
 					Console.WriteLine("Error");
 				}
 			}
 			
 		}
 		
 		public void eliminarAlumno(){
 			String codigo;
 			Console.Write("Codigo del alumno: ");
 			codigo=Console.ReadLine();
 			if(tabla.ContainsKey(codigo)){
 			   	tabla.Remove(codigo);
 			   	Console.WriteLine("Procesando........ \nBorrado el alumno: "+ codigo);
 			}
 			   	else Console.WriteLine("No se encontro ese codigo "+codigo);
 			   	Console.WriteLine("\n*****************************");
 		}
 		
 		public static void Main(string[] args)
 		{
 			int opcion;
 			Program programa=new Program();
 			do{
 				Console.WriteLine("\n***** Agenda de Alumnos *****\n");
 				Console.WriteLine(" 1)Agregar Alumno\n 2)Mostrar Alumnos \n 3)Eliminar Alumno\n 4)Salir");
 				opcion=int.Parse(Console.ReadLine());
 				switch(opcion){
 						case 1:programa.agregarAlumno();
 						break;
 						case 2:programa.verAlumnos();
 						break;
 						case 3:programa.eliminarAlumno();
 						break;
 						default:Console.WriteLine("Estas saliendo del programa.....");
 						Console.ReadLine();
 						break;
 				}
 			}while (opcion<4);
 		}
 	}
 }