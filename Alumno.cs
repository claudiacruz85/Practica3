/*
 * Created by SharpDevelop.
 * User: Claudia
 * Date: 11/03/2015
 * Time: 10:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;

namespace Practica_3
{

	public class Alumno
	{
		private String nombre;
		private String codigo;
		
		public Alumno(String n, String c)
		{
			nombre=n;
			codigo=c;
		}
		public Alumno(){
			nombre="";
			codigo="";
		}
		
		public void setNombre(String nombre){
			this.nombre=nombre;
		}
		public String getNombre(){
			return nombre;
		}
		public void setCodigo(String nombre){
			this.nombre=nombre;
	}
		public String getCodigo(){
			return codigo;
		}
		
		public String getDatos(){
			return "nombre: "+nombre+"\n" + "Codigo: "+codigo+"\n*********************";
		}
	}
}