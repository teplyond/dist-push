namespace DochazkovySystem
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.databázeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vymazatDatabáziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zálohovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.obnovaZeZálohyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vložZaměstnanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.nastaveníToolStripMenuItem,
            this.nápovědaToolStripMenuItem,
            this.vložZaměstnanceToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(885, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// souborToolStripMenuItem
			// 
			this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.konecToolStripMenuItem});
			this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
			this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.souborToolStripMenuItem.Text = "Soubor";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.importToolStripMenuItem.Text = "Import";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// konecToolStripMenuItem
			// 
			this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
			this.konecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.konecToolStripMenuItem.Text = "Konec";
			// 
			// nastaveníToolStripMenuItem
			// 
			this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databázeToolStripMenuItem});
			this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
			this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.nastaveníToolStripMenuItem.Text = "Nastavení";
			// 
			// databázeToolStripMenuItem
			// 
			this.databázeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vymazatDatabáziToolStripMenuItem,
            this.zálohovatToolStripMenuItem,
            this.obnovaZeZálohyToolStripMenuItem});
			this.databázeToolStripMenuItem.Name = "databázeToolStripMenuItem";
			this.databázeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.databázeToolStripMenuItem.Text = "Databáze";
			// 
			// vymazatDatabáziToolStripMenuItem
			// 
			this.vymazatDatabáziToolStripMenuItem.Name = "vymazatDatabáziToolStripMenuItem";
			this.vymazatDatabáziToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.vymazatDatabáziToolStripMenuItem.Text = "Vymazat databázi";
			// 
			// zálohovatToolStripMenuItem
			// 
			this.zálohovatToolStripMenuItem.Name = "zálohovatToolStripMenuItem";
			this.zálohovatToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.zálohovatToolStripMenuItem.Text = "Zálohovat";
			// 
			// obnovaZeZálohyToolStripMenuItem
			// 
			this.obnovaZeZálohyToolStripMenuItem.Name = "obnovaZeZálohyToolStripMenuItem";
			this.obnovaZeZálohyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.obnovaZeZálohyToolStripMenuItem.Text = "Obnova ze zálohy";
			// 
			// nápovědaToolStripMenuItem
			// 
			this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikaciToolStripMenuItem});
			this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
			this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.nápovědaToolStripMenuItem.Text = "Nápověda";
			// 
			// oAplikaciToolStripMenuItem
			// 
			this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
			this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
			// 
			// vložZaměstnanceToolStripMenuItem
			// 
			this.vložZaměstnanceToolStripMenuItem.Name = "vložZaměstnanceToolStripMenuItem";
			this.vložZaměstnanceToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(885, 350);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(877, 324);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Zaměstnanci";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(741, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Nový zaměstnanec";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(256, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Vyhledat";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(149, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(101, 20);
			this.textBox1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Rodné číslo zaměstnance";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 37);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(863, 279);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.button4);
			this.tabPage5.Controls.Add(this.label4);
			this.tabPage5.Controls.Add(this.label3);
			this.tabPage5.Controls.Add(this.dateTimePicker2);
			this.tabPage5.Controls.Add(this.dateTimePicker1);
			this.tabPage5.Controls.Add(this.dataGridView3);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(877, 324);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Docházka vybraného zaměstnance";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(680, 10);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(189, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Vložení nového dne";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(221, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Do";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Od";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(248, 11);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(159, 20);
			this.dateTimePicker2.TabIndex = 2;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(35, 11);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(8, 43);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(861, 278);
			this.dataGridView3.TabIndex = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button2);
			this.tabPage4.Controls.Add(this.dataGridView2);
			this.tabPage4.Controls.Add(this.label2);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(877, 324);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Status Dne";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(732, 22);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Vlož nový status dne";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(11, 48);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(858, 268);
			this.dataGridView2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Statusy dne v databázi";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(877, 324);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Statistika";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(877, 324);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Export";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(877, 324);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "-";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 377);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Docházkový systém";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem databázeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vymazatDatabáziToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zálohovatToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem obnovaZeZálohyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oAplikaciToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripMenuItem vložZaměstnanceToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.BindingSource bindingSource2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.BindingSource bindingSource3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TabPage tabPage6;
	}
}

