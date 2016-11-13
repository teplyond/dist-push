namespace DochazkovySystem
{
	partial class VlozDochazku
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(122, 33);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(389, 20);
			this.dateTimePicker1.TabIndex = 0;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "HH:mm";
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(122, 59);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(389, 20);
			this.dateTimePicker2.TabIndex = 1;
			this.dateTimePicker2.Value = new System.DateTime(2016, 10, 28, 7, 0, 0, 0);
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.CustomFormat = "HH:mm";
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker3.Location = new System.Drawing.Point(122, 85);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(389, 20);
			this.dateTimePicker3.TabIndex = 2;
			this.dateTimePicker3.Value = new System.DateTime(2016, 10, 28, 15, 0, 0, 0);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(122, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 21);
			this.comboBox1.TabIndex = 3;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(122, 111);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(389, 21);
			this.comboBox2.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Zaměstnanec";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Datum";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Příchod";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Odchod";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Status dne";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(241, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Vložit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(262, 147);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(249, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Zavřít";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(382, 6);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(129, 21);
			this.comboBox3.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(95, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Rc";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(328, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Příjmení";
			// 
			// VlozDochazku
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 180);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dateTimePicker3);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "VlozDochazku";
			this.Text = "VlozDochazku";
			this.Load += new System.EventHandler(this.VlozDochazku_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}