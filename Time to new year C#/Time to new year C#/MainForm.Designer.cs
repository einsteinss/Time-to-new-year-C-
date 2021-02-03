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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label1.Location = new System.Drawing.Point(232, 245);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "000";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label2.Location = new System.Drawing.Point(412, 245);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 51);
			this.label2.TabIndex = 1;
			this.label2.Text = "00";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label3.Location = new System.Drawing.Point(336, 245);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 51);
			this.label3.TabIndex = 2;
			this.label3.Text = "00";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label4.Location = new System.Drawing.Point(317, 245);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 51);
			this.label4.TabIndex = 3;
			this.label4.Text = ":";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label5.Location = new System.Drawing.Point(395, 245);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 51);
			this.label5.TabIndex = 4;
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label6.Location = new System.Drawing.Point(468, 245);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 51);
			this.label6.TabIndex = 5;
			this.label6.Text = ":";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label7.Location = new System.Drawing.Point(488, 245);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 51);
			this.label7.TabIndex = 6;
			this.label7.Text = "00";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(818, 365);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Time to new year C#";
			this.ResumeLayout(false);

		}
	}
}
