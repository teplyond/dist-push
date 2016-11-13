using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Collections;
using System.Data.SqlClient;
using System.IO;

namespace DochazkovySystem
{
	class StatusDne
	{
		public string sConnectionString =
				String.Format("{0};{1}\"{2}\"{3}",
				@"Data Source=(LocalDB)\v11.0",
				 "AttachDbFilename=",
				  System.IO.Path.GetFullPath(@"..\..\dochazka.mdf"),
				  ";Integrated Security=True;Connect Timeout=30");

		public string DConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + System.IO.Path.GetFullPath(@"..\..\dochazka.mdf") + "";

		private int Id;
		private String name = "";

		public StatusDne(int Id)
		{
			this.Id = Id;
			setValues();
		}

		public StatusDne(string name)
		{
			this.name = name;
			insertValues();
		}
		private void insertValues()
		{
			SqlConnection conn = null;
			try {
				conn = new SqlConnection(sConnectionString);
				SqlCommand cmd = new SqlCommand("INSERT INTO StatusDne (Nazev) VALUES (@Nazev)");
				cmd.CommandType = CommandType.Text;
				cmd.Connection = conn;
				cmd.Parameters.AddWithValue("@Nazev", name);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new Exception("Duplikatni nazev!");
			}
			finally
			{
				if (conn != null)
					conn.Close();
				setId();
			};
		}
		private void setId()
		{


			SqlConnection conn = null;
			DataSet dt = new DataSet();
			try
			{

				String podminka = "Nazev = '" + this.name+"'";
				conn = new SqlConnection(sConnectionString);
				conn.Open();
				SqlDataAdapter namee = new SqlDataAdapter("SELECT * FROM StatusDne WHERE " + podminka, conn);
				namee.Fill(dt, "StatusDne");
				this.Id = System.Convert.ToInt32(dt.Tables[0].Rows[0].ItemArray[0].ToString());

			}
			catch (Exception ex)
			{
				this.Id = -1;
			}
			finally
			{
				if (conn != null)
					conn.Close();
			};
		}
		private void setValues(){
			
			
			SqlConnection conn = null;
			DataSet dt = new DataSet();
			try
			{
				
				String podminka = "Id = " + Convert.ToString(Id);
				conn = new SqlConnection(sConnectionString);
				conn.Open();
				SqlDataAdapter name = new SqlDataAdapter("SELECT * FROM StatusDne WHERE " + podminka, conn);
				name.Fill(dt, "StatusDne");
				this.name = dt.Tables[0].Rows[0].ItemArray[1].ToString();
			
			}
			catch (Exception ex)
			{
				this.name = null;
			}
			finally
			{
				if (conn != null)
					conn.Close();
			};
		}
		public int getId()
		{
			return Id;
		}

		public String getName()
		{
			return name;
		}
	}
}
