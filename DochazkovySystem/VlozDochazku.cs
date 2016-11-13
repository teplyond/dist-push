using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DochazkovySystem
{
	public partial class VlozDochazku : Form
	{	

		public BindingSource zamestnanec;
		public BindingSource statusDne;
		public VlozDochazku(BindingSource zam, BindingSource stat)
		{
			InitializeComponent();
			this.zamestnanec = zam;
			this.statusDne = stat;
			comboBox1.DataSource = this.zamestnanec;
			comboBox2.DataSource = this.statusDne;
			comboBox3.DataSource = this.zamestnanec;
			comboBox2.DataSource = this.statusDne;
			comboBox1.DisplayMember = "Rc";
			comboBox2.DisplayMember = "Nazev";
			comboBox3.DisplayMember = "Prijmeni";
			comboBox3.ValueMember = "Id";
			comboBox2.ValueMember = "Id";
			comboBox1.ValueMember = "Id";
			
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void VlozDochazku_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Dochazka a = new Dochazka(dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value, System.Convert.ToInt32(comboBox1.SelectedValue), System.Convert.ToInt32(comboBox2.SelectedValue));
				MessageBox.Show("Status byl vložen." + " Id je " + System.Convert.ToString(a.getId()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
			finally
			{
				
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			dateTimePicker2.Value = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 07:00:00");
			dateTimePicker3.Value = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 15:00:00");
		}
	}
}
