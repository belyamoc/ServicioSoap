﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WSsoap1
{
	/// <summary>
	/// Descripción breve de WebService1
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
	// [System.Web.Script.Services.ScriptService]
	public class WebService1 : System.Web.Services.WebService
	{

		[WebMethod]
		public string HelloWorld()
		{
			return "Hola a todos";
		}

		[WebMethod]
		public DataSet ListaProductos()
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Data Source=.; Initial Catalog=AdventureWorks2014; Integrated Security=true";
				
			SqlDataAdapter ad = new SqlDataAdapter("SELECT SUM(UnitPrice * OrderQty) FROM Sales.SalesOrderDetail", conn);
			DataSet ds = new DataSet();
			ad.Fill(ds);
				return ds;
		
		}

	}
}
