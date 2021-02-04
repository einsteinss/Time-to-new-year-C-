/*
 * Created by SharpDevelop.
 * User: Sela Smith
 * Date: 03/02/2021
 * Time: 11:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Time_to_new_year_C_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			timer1.Start();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DateTime endTime = new DateTime(2022, 1, 1, 0, 0, 0);
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			TimeSpan ts = endTime.Subtract(DateTime.Now);
			
			d.Text = ts.Days.ToString();
			h.Text = ts.Hours.ToString();
			m.Text = ts.Minutes.ToString();
			s.Text = ts.Seconds.ToString();
		}
	}
}
