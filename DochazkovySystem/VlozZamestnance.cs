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
	public partial class VlozZamestnance : Form
	{
		public VlozZamestnance()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text ==""||textBox4.Text ==""||textBox3.Text ==""||textBox2.Text =="")
				MessageBox.Show("Nejsou vyplněna všechna pole");
			else
			{
				try
				{
					Zamestnanec a = new Zamestnanec(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value, System.Convert.ToDouble(numericUpDown1.Value));
					MessageBox.Show("Zamestnanec byl vlozen. Jeho Id je "+a.getId());
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					textBox3.Text = "";
				}
				finally
				{
				textBox1.Text ="";
				textBox4.Text ="";
				textBox3.Text ="";
				textBox2.Text ="";

				}
			}
		}
	}
}
