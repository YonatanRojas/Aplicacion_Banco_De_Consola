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
	/// Description of Cuenta_bancaria.
	/// </summary>
	public class CuentaBancaria
	{
		//Atributos
		protected int nro;
		private string apellido, dni;
		private double saldo;
		
		//Constructor
		public CuentaBancaria(int n, string a, string dni, double s)
		{
			nro = n;
			apellido = a;
			this.dni = dni;
			saldo = s;
		}
		//Set y get(Propiedades)
		public double Saldo{
			set{ saldo = value; }
			get{ return saldo; }
		}
		public int Nro{
			set{ this.nro = value; }
			get{ return nro; }
		}
		public string Apellido{ 
			set{ apellido = value; }
			get{ return apellido; }
		}
		public string Dni{
			set{ dni = value;}
			get{ return dni; }
		}
		
		//Comportamiento/metodos
		public void imprimirCuenta(){
			Console.WriteLine("Numero: {0}",nro);
			Console.WriteLine("apellido del Titular: {0}", apellido);
			Console.WriteLine("Dni: {0}", dni);
			Console.WriteLine("Saldo Actual: {0}",saldo);
			
		}
		
	}
}
