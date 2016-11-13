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
	public partial class VlozStatus : Form
	{
		public VlozStatus()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try { 
				StatusDne a = new StatusDne(textBox1.Text);
				MessageBox.Show("Status byl vložen. Jméno je "+a.getName()+" Id je "+System.Convert.ToString(a.getId()));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			
			}
			finally
			{
				textBox1.Text = "";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
