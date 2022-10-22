/*
 * Created by SharpDevelop.
 * User: Yonatan
 * Date: 15/10/2022
 * Time: 16:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
//using System.Runtime.Serialization;

namespace Banco
{
	/// <summary>
	/// Description of SaldoInsuficienteExcepcion.
	/// </summary>
	public class SaldoInsuficienteExcepcion : Exception
	{
		public SaldoInsuficienteExcepcion()
		{
		}

	 	public SaldoInsuficienteExcepcion(string message) : base(message)
		{
		}

		public SaldoInsuficienteExcepcion(string message, Exception innerException) : base(message, innerException)
		{
		}

		// This constructor is needed for serialization.
		protected SaldoInsuficienteExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}