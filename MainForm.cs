/*
 * Created by SharpDevelop.
 * User: adfgh
 * Date: 15-02-2019
 * Time: 14:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba1
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{

		}
		void Button2Click(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (button1.Bottom+15 < button2.Top-15){
			button1. Top = button1. Top+16;
			button2. Top = button2. Top-16;
												}
		}
		void Button4Click(object sender, EventArgs e)
		{
			if (button1.Top > 0 && button2.Bottom < Form.ActiveForm.Height){
					button1. Top = button1. Top-16;
					button2. Top = button2. Top+16;
													}
		}
	}
}
