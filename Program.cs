/*
 * Created by SharpDevelop.
 * User: Yonatan
 * Date: 3/10/2022
 * Time: 11:03
 	Fecha de entrega antes del 22/11/2022
 	Grupo = 10
 	Proyecto: Banco
 */
using System;
using System.Collections;

namespace Banco
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList cuentas = new ArrayList();
			
			
			
			Bienvenida();
			Menu();
			
	
	
			Console.Write("Presiona alguna tecla para Cerrar");
			Console.ReadKey(true);
		}
		static void Bienvenida(){
			Console.WriteLine("¡Bienvenido al mejor Banco De America!");
			Console.WriteLine("----------------");
			
		}
		static void opciones(){
			Console.WriteLine("Opciones: ");
			Console.WriteLine("'1': Agregar una cuenta al banco.");
			Console.WriteLine("'2': Eliminar una Cuenta.");
			Console.WriteLine("'3': Listado de clientes que tienen mas de una cuenta.");
			Console.WriteLine("'4': Realizar una extraccion.");
			Console.WriteLine("'5': Depositar dinero en cuenta.");
			Console.WriteLine("'6': Transferir Dinero.");
			Console.WriteLine("'7': Listado de Cuentas.");
			Console.WriteLine("'8': Listado de clientes.");
			Console.WriteLine("'0': Cerrar Programa.");
			Console.WriteLine("----------------");
			Console.WriteLine("Ingrese Una Opcion: ");
		}
		static void Menu(){
			opciones();
			string opcion = Console.ReadLine();
			while(opcion != "0"){
				if(opcion == "1"){
					//AGREGAR UNA CUENTA
					
				}
				if(opcion == "2"){
					//ELIMINAR UNA CUENTA
				}
				if(opcion == "3"){
					//LISTAOD DE CLIENTES QUE TIENEN MAS DE UNA CUENTA
				}
				if(opcion == "4"){
					//REALIZAR UNA EXTRACCION DEL DINERO Y MOSTRAR
				}
				if(opcion == "5"){
					//DEPOSITAR DINERO EN UNA CUENTA
				}
				if(opcion == "6"){
					//TRANSFERIR DINERO
				}
				if(opcion == "7"){
					//LISTADO DE CUENTAS
					listaClientes();
				}
				if(opcion == "8"){
					//LISTADO DE CLIENTES
					
				}
				opciones();
				opcion = Console.ReadLine();
			}
		}
		static void inicio(){
			Console.WriteLine("Ingrese su Nombre");
		}
		static void agregarCuenta(Banco B){
			string apellido, dni;
			int nro;
			double saldo;
			string nombre, direccion, mail;
			int telefono;
			
			Console.WriteLine("Quiere Crear Una Cuenta(si, no): ");
			string consulta = Console.ReadLine();
			while(consulta != "no" && consulta == "si"){
				Console.WriteLine("Ingrese un apellido para el titular de la cuenta: ");
				apellido = Console.ReadLine();
				Console.WriteLine("Ingrese el Nombre del titular de la cuenta: ");
				nombre = Console.ReadLine();
				Console.WriteLine("Ingrese un Email para esta cuenta.");
				mail = Console.ReadLine();
				Console.WriteLine("Ingrese un numero de telefono: ");
				telefono = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese la direccion del propietario de la cuenta: ");
				direccion = Console.ReadLine();
				
				Console.WriteLine("Ingrese un numero de cuenta: ");
				nro = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese el DNI del titular de la cuenta: ");
				dni = Console.ReadLine();
				Console.WriteLine("Ingrese el saldo de la cuenta: ");
				saldo = double.Parse(Console.ReadLine());
				
				Cliente_Nuevo = new Clientes(nombre, apellido, dni, direccion, telefono, mail);
				Cuenta_bancaria_nueva = new CuentaBancaria(nro, apellido, dni, saldo);
				B.AgregarCuenta(Cuenta_bancaria_nueva, Cliente_Nuevo);
				
				
			}

	
			
			
			
		}
	}
}