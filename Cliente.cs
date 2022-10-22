/*
 * Created by SharpDevelop.
 * User: Yonatan
 * Date: 10/10/2022
 * Time: 12:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Banco
{
	/// <summary>
	/// Description of Clientes.
	/// </summary>
	public class Clientes
	{
		//Atributos
		private string nombre, apellido, direccion, mail;
		private int telefono, dni;
		private ArrayList listClientes;
		
		//Constructor
		public Clientes(string n, string a, int dni, string d, int t, string m)
		{
			nombre = n;
			apellido = a;
			this.dni = dni;
			direccion = d;
			telefono = t;
			mail = m;
			listClientes = ArrayList();
		}
		//Set y get 
		public int Dni{
			set{ this.dni = value; }
			get{ return dni; }
		}
		public string Nombre{
			set{ this.nomber = value;}
			get{ return nombre_apellido; }
		}
		public string Apellido{
			set{ apellido = value;}
			get{ return apellido; }
		}
		
		public int Telefono{
			set{ this.telefono = value; }
			get{ return telefono;}
		}
		public string Direccion{
			set{ direccion = value;}
			get{ return direccion;}
		}
		
		
		//Comportamiento/ metodos
		public void imprimirCliente(){
			Console.WriteLine("¡Datos de Cliente!");
			Console.WriteLine("Nombre: {0} {1}.", nombre, apellido);
			Console.WriteLine("Dni: {0}.", dni);
			Console.WriteLine("Direccion: {0}.", direccion);
			Console.WriteLine("Telefono: {0}.", telefono);
			Console.WriteLine("Correo Electronico: {0}", mail);
		}
		
		
	}
}
