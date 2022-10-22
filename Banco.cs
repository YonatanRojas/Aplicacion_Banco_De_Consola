/*
 * Created by SharpDevelop.
 * User: Yonatan
 * Date: 10/10/2022
 * Time: 12:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collentions;

namespace Banco
{
	/// <summary>
	/// Description of Banco.
	/// </summary>
	public class Banco
	{
		//Atributos
		private string nombre;
		private ArrayList Cuentas_bancarias;
		private ArrayList Clientes;
		
		//Constructor
		public Banco(string n)
		{
			this.nombre = n;
			Cuentas_bancarias = new ArrayList();
			Clientes = new ArrayList();
		}
		
		//Set y get 
		public string Nombre{
			set{ nombre = value; }
			get{ return nombre; }
		}
		
		
		//Comportamiento/Metodos
		public void AgregarCuenta(CuentaBancaria c, Clientes u){
			//Agregando Cuentas
			Cuentas_bancarias.Add(c);
			Clientes.Add(u);
		}
		public void EliminarCuenta(Cuenta_bancaria c, Clientes u){
			//eliminar una cuenta del banco
			Cuentas_bancarias.Remove(c);
			Clientes.Remove(u);
		}
		public double DepositarDinero(double saldo_Cuenta, double s){
			//Agregando El saldo
			double NuevoSaldo = saldo_Cuenta + sr;
			return NuevoSaldo;
		}
		public void RealizarExtraccionDinero(double saldo_Cuenta, double s){
			//Sacar dinero 
			double NuevoSaldo = saldo_Cuenta - s;
		}
		public void transferirDinero(double saldo_Cuenta1, double saldo_Cuenta2, double s){
			//pasar dinero a otra cuenta en el array.
			/*estaría bien que en el método transferirDinero realices la acción de restar 
		   dinero de una cuenta y sumarle a otra cuenta la misma cantidad*/
			double RestoACuenta = saldo_Cuenta1 - s;
			double SumandoleAOtraCuenta = saldo_Cuenta2 + s;
		}
		public ArrayList listaClientes(){
			return Clientes;
		}
		public ArrayList listaCuentasBancarias(){
			return Cuentas_bancarias;
		}
	}
}
