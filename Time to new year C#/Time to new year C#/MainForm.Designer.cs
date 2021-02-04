/*
 * Created by SharpDevelop.
 * User: Sela Smith
 * Date: 03/02/2021
 * Time: 11:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Time_to_new_year_C_
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label d;
		private System.Windows.Forms.Label m;
		private System.Windows.Forms.Label h;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label s;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.d = new System.Windows.Forms.Label();
			this.m = new System.Windows.Forms.Label();
			this.h = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.s = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// d
			// 
			this.d.BackColor = System.Drawing.Color.Transparent;
			this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.d.ForeColor = System.Drawing.Color.White;
			this.d.Location = new System.Drawing.Point(271, 269);
			this.d.Name = "d";
			this.d.Size = new System.Drawing.Size(94, 51);
			this.d.TabIndex = 0;
			this.d.Text = "000";
			// 
			// m
			// 
			this.m.BackColor = System.Drawing.Color.Transparent;
			this.m.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.m.ForeColor = System.Drawing.Color.White;
			this.m.Location = new System.Drawing.Point(451, 269);
			this.m.Name = "m";
			this.m.Size = new System.Drawing.Size(70, 51);
			this.m.TabIndex = 1;
			this.m.Text = "00";
			// 
			// h
			// 
			this.h.BackColor = System.Drawing.Color.Transparent;
			this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.h.ForeColor = System.Drawing.Color.White;
			this.h.Location = new System.Drawing.Point(375, 269);
			this.h.Name = "h";
			this.h.Size = new System.Drawing.Size(70, 51);
			this.h.TabIndex = 2;
			this.h.Text = "00";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(356, 269);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 51);
			this.label4.TabIndex = 3;
			this.label4.Text = ":";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(434, 269);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 51);
			this.label5.TabIndex = 4;
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(507, 269);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 51);
			this.label6.TabIndex = 5;
			this.label6.Text = ":";
			// 
			// s
			// 
			this.s.BackColor = System.Drawing.Color.Transparent;
			this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.s.ForeColor = System.Drawing.Color.White;
			this.s.Location = new System.Drawing.Point(527, 269);
			this.s.Name = "s";
			this.s.Size = new System.Drawing.Size(70, 51);
			this.s.TabIndex = 6;
			this.s.Text = "00";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(285, 320);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 31);
			this.label8.TabIndex = 7;
			this.label8.Text = "Dias";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(367, 320);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(84, 31);
			this.label9.TabIndex = 8;
			this.label9.Text = "Horas";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(456, 320);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 31);
			this.label10.TabIndex = 9;
			this.label10.Text = "Min";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(531, 320);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 31);
			this.label11.TabIndex = 10;
			this.label11.Text = "Seg";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(304, 112);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(266, 53);
			this.label12.TabIndex = 11;
			this.label12.Text = "Novo Ano 2022";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(214, 195);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(429, 31);
			this.label13.TabIndex = 12;
			this.label13.Text = "Contagem Regressiva Para o Novo Ano";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(810, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(872, 376);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.s);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.h);
			this.Controls.Add(this.m);
			this.Controls.Add(this.d);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Time to new year C#";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
