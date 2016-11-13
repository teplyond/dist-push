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
	class Dochazka
	{
			public string sConnectionString =
				String.Format("{0};{1}\"{2}\"{3}",
				@"Data Source=(LocalDB)\v11.0",
				 "AttachDbFilename=",
				  System.IO.Path.GetFullPath(@"..\..\dochazka.mdf"),
				  ";Integrated Security=True;Connect Timeout=30");

			public string DConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + System.IO.Path.GetFullPath(@"..\..\dochazka.mdf") + "";

			private int Id;
			private DateTime datum;
			private DateTime prichod;
			private DateTime odchod;
			private double OdpracovaneH;
			private Zamestnanec zamestnanec;
			private StatusDne statusdne;
			
			/*
			public Dochazka(int Id)
			{
				this.Id = Id;
			}
			*/
			public Dochazka(DateTime datum, DateTime prichod, DateTime odchod, int zamestnanec, int statusdne)
			{
				this.datum = datum;
				this.prichod = prichod;
				this.odchod = odchod;
				TimeSpan dat = odchod-prichod;
				this.OdpracovaneH = dat.Hours;
				this.zamestnanec = new Zamestnanec(zamestnanec);
				this.statusdne = new StatusDne(statusdne);
				insertValues();

			}

			private void insertValues()
			{
				SqlConnection conn = null;
				try
				{
					conn = new SqlConnection(sConnectionString);
					SqlCommand cmd = new SqlCommand("INSERT INTO Dochazka (Datum, Prichod, Odchod, OdpracovaneH, StatusDne, Zamestnanec) VALUES (@Datum, @Prichod, @Odchod, @OdpracovaneH, @StatusDne, @Zamestnanec)");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = conn;
					cmd.Parameters.AddWithValue("@Datum", this.datum);
					cmd.Parameters.AddWithValue("@Prichod", this.prichod);
					cmd.Parameters.AddWithValue("@Odchod", this.odchod);
					cmd.Parameters.AddWithValue("@OdpracovaneH", this.OdpracovaneH);
					cmd.Parameters.AddWithValue("@StatusDne", this.statusdne.getId());
					cmd.Parameters.AddWithValue("@Zamestnanec", System.Convert.ToString(this.zamestnanec.getId()));
					conn.Open();
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw new Exception("Duplikatni dochazka!");
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

					String podminka = "Datum = '" + this.datum.ToString("yyyy-MM-dd HH:mm:ss") + "' AND Zamestnanec = " + this.zamestnanec.getId();
					conn = new SqlConnection(sConnectionString);
					conn.Open();
					SqlDataAdapter namee = new SqlDataAdapter("SELECT * FROM Dochazka WHERE " + podminka, conn);
					namee.Fill(dt, "dochazka");
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
	/*
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
	  */
			public int getId()
		{
			return Id;
		}

			public DateTime getDatum()
		{
			return datum;
		}

			public DateTime getPrichod()
		{
			return prichod;
		}

			public DateTime getOdchod()
		{
			return odchod;
		}

			public double getOdprachvaneH()
		{
			return OdpracovaneH;
		}

			public Zamestnanec getZamestnanec()
		{
			return zamestnanec;
		}

			public StatusDne getStatusDne()
		{
			return statusdne;
		}

	}
}
