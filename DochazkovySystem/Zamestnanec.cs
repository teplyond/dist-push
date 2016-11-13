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
	class Zamestnanec
	{
			public string sConnectionString =
				String.Format("{0};{1}\"{2}\"{3}",
				@"Data Source=(LocalDB)\v11.0",
				 "AttachDbFilename=",
				  System.IO.Path.GetFullPath(@"..\..\dochazka.mdf"),
				  ";Integrated Security=True;Connect Timeout=30");

			public string DConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + System.IO.Path.GetFullPath(@"..\..\dochazka.mdf") + "";

			private int Id;
			private String Jmeno;
			private String Prijmeni;
			private String Rc;
			private DateTime DatumNastupu;
			private String PracovniPozice;
			private double TydeniUvazek;
			

			public Zamestnanec(int Id)
			{
				this.Id = Id;
			}

			public Zamestnanec(String Jmeno, String Prijmeni, String Rc, String PracovniPozice, DateTime DatumNastupu, double TydeniUvazek)
			{
				this.Jmeno = Jmeno;
				this.Prijmeni = Prijmeni;
				this.Rc = Rc;
				this.PracovniPozice = PracovniPozice;
				this.DatumNastupu = DatumNastupu;
				this.TydeniUvazek = TydeniUvazek;
				insertValues();

			}

			private void insertValues()
			{
				SqlConnection conn = null;
				try
				{
					conn = new SqlConnection(sConnectionString);
					SqlCommand cmd = new SqlCommand("INSERT INTO Zamestnanec (Jmeno, Prijmeni, Rc, PracovniPozice, DatumNastupu, TydeniUvazekH) VALUES (@Jmeno, @Prijmeni, @Rc, @PracovniPozice, @DatumNastupu, @TydeniUvazekH)");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = conn;
					cmd.Parameters.AddWithValue("@Jmeno", this.Jmeno);
					cmd.Parameters.AddWithValue("@Prijmeni", this.Prijmeni);
					cmd.Parameters.AddWithValue("@Rc", this.Rc);
					cmd.Parameters.AddWithValue("@PracovniPozice", this.PracovniPozice);
					cmd.Parameters.AddWithValue("@DatumNastupu", this.DatumNastupu);
					cmd.Parameters.AddWithValue("@TydeniUvazekH", System.Convert.ToString(this.TydeniUvazek));
					conn.Open();
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw new Exception("Duplikatni rodne cislo!");
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

					String podminka = "Rc = '" + this.Rc + "'";
					conn = new SqlConnection(sConnectionString);
					conn.Open();
					SqlDataAdapter namee = new SqlDataAdapter("SELECT * FROM Zamestnanec WHERE " + podminka, conn);
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
				SqlDataAdapter name = new SqlDataAdapter("SELECT * FROM Zamestnanec WHERE " + podminka, conn);
				name.Fill(dt, "Zamestnanec");
				this.Jmeno = dt.Tables[0].Rows[0].ItemArray[1].ToString();
				this.Prijmeni = dt.Tables[0].Rows[0].ItemArray[2].ToString();
				this.Rc = dt.Tables[0].Rows[0].ItemArray[3].ToString();
				this.DatumNastupu = DateTime.ParseExact(dt.Tables[0].Rows[0].ItemArray[4].ToString(), "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
				this.PracovniPozice = dt.Tables[0].Rows[0].ItemArray[5].ToString();
				this.TydeniUvazek = System.Convert.ToDouble(dt.Tables[0].Rows[0].ItemArray[6].ToString());
			
			}
			catch (Exception ex)
			{
				this.Jmeno = null;
				this.Prijmeni = null;
				this.Rc = null;
				this.PracovniPozice = null;
				this.TydeniUvazek = -1;
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

			public String getJmeno()
		{
			return Jmeno;
		}

			public String getPrijmeni()
		{
			return Prijmeni;
		}

			public String getRc()
		{
			return Rc;
		}

			public String getPraconiPozice()
		{
			return PracovniPozice;
		}

			public double getTydeniUvazek()
		{
			return TydeniUvazek;
		}

			public DateTime getDatumNastupu()
		{
			return DatumNastupu;
		}

	}
}
