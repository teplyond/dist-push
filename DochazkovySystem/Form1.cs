using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DochazkovySystem
{
	public partial class Form1 : Form
	{
		private SqlDataAdapter dataAdapter = new SqlDataAdapter();
		private SqlDataAdapter dataAdapter1 = new SqlDataAdapter();
		private SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
		int load = 1;
		public Form1()
		{	this.load=1;
			InitializeComponent();
			GetData();
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			

		}

		private void vložStatusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void GetData()
		{
			try
			{
			    string sConnectionString =
				String.Format("{0};{1}\"{2}\"{3}",
				@"Data Source=(LocalDB)\v11.0",
				 "AttachDbFilename=",
				  System.IO.Path.GetFullPath(@"..\..\dochazka.mdf"),
				  ";Integrated Security=True;Connect Timeout=30");

				
				dataAdapter = new SqlDataAdapter("Select * FROM StatusDne where 1=1 Order by Nazev ASC", sConnectionString);
				dataAdapter1 = new SqlDataAdapter("Select * FROM Zamestnanec where 1=1 Order by Prijmeni ASC", sConnectionString);
				
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
				SqlCommandBuilder commandBuilder1 = new SqlCommandBuilder(dataAdapter1);

				DataTable table = new DataTable();
				DataTable table1 = new DataTable();
				table.Locale = System.Globalization.CultureInfo.InvariantCulture;
				dataAdapter.Fill(table);
				table1.Locale = System.Globalization.CultureInfo.InvariantCulture;
				dataAdapter1.Fill(table1);

				bindingSource1.DataSource = table;
				bindingSource2.DataSource = table1;

				dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
				dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

				dataGridView2.DataSource = bindingSource1;
				dataGridView1.DataSource = bindingSource2;
				
			}
			catch (Exception e)
			{
				MessageBox.Show("Chby db!!");
			}
		}

		private void GetDochazka(int id_zam)
		{
			try
			{
				string sConnectionString =
				String.Format("{0};{1}\"{2}\"{3}",
				@"Data Source=(LocalDB)\v11.0",
				 "AttachDbFilename=",
				  System.IO.Path.GetFullPath(@"..\..\dochazka.mdf"),
				  ";Integrated Security=True;Connect Timeout=30");


				dataAdapter2 = new SqlDataAdapter("Select * FROM Dochazka where Zamestnanec = "+id_zam+" Order by Datum ASC", sConnectionString);
				

				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter2);
				

				DataTable table = new DataTable();
				
				table.Locale = System.Globalization.CultureInfo.InvariantCulture;
				dataAdapter2.Fill(table);
			

				bindingSource3.DataSource = table;
				

				dataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
				dataGridView3.DataSource = bindingSource3;

			}
			catch (Exception e)
			{
				MessageBox.Show("Chyba db!!");
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Form status = new VlozStatus();
			status.ShowDialog();
			GetData();
		}


		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form zam = new VlozZamestnance();
			zam.ShowDialog();
			GetData();
		}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			try {
			if (this.load==0)
				GetDochazka(System.Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
			}
			catch (Exception ex)
			{


			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.load = 0;
			dataGridView1_SelectionChanged(sender, e);
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			try {
				if (dateTimePicker2.Value < dateTimePicker1.Value)
				dateTimePicker2.Value = dateTimePicker1.Value.AddDays(1) ;
				 bindingSource3.Filter = String.Format("Datum >= '{0:yyyy-MM-dd}' AND Datum < '{1:yyyy-MM-dd}'", dateTimePicker1.Value, dateTimePicker2.Value);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form dochazka = new VlozDochazku(bindingSource2, bindingSource1);
			dochazka.ShowDialog();
			dataGridView1_SelectionChanged(sender, e);
		
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (dateTimePicker2.Value < dateTimePicker1.Value)
					dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
				bindingSource3.Filter = String.Format("Datum >= '{0:yyyy-MM-dd}' AND Datum < '{1:yyyy-MM-dd}'", dateTimePicker1.Value, dateTimePicker2.Value);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	




	}
}
