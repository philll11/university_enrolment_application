using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_212
{
	public partial class StudentAddWin : Form
	{
		MainWin _mw;
		public StudentAddWin(MainWin mw)
		{
			InitializeComponent();
			this._mw = mw;


			//	Event handlers for watermark text in textboxes
			sdtNmeTxBx.GotFocus += new EventHandler(this.NameGotFocus);
			sdtNmeTxBx.LostFocus += new EventHandler(this.NameLostFocus);
			sdtBirTxBx.GotFocus += new EventHandler(this.BirthdayGotFocus);
			sdtBirTxBx.LostFocus += new EventHandler(this.BirthdayLostFocus);
			sdtIDTxBx.GotFocus += new EventHandler(this.IdGotFocus);
			sdtIDTxBx.LostFocus += new EventHandler(this.IdLostFocus);
			sdtAdyTxBx.GotFocus += new EventHandler(this.AddressGotFocus);
			sdtAdyTxBx.LostFocus += new EventHandler(this.AddressLostFocus);
		}

		private void SdtCfmBtnClick(object sender, EventArgs e)
		{
			if (sdtNmeTxBx.Text != "Joe Dow")
			{
				nameEro.Visible = false;				
				if (Int32.TryParse(sdtIDTxBx.Text, out int id) && sdtIDTxBx.Text != "12345678")
				{
					idEro.Visible = false;
					if (sdtAdyTxBx.Text != "123 Upto Street")
					{							
						adyEro.Visible = false;
						try
						{
							Student _myStudent = new Student(sdtNmeTxBx.Text, Convert.ToDateTime(sdtBirTxBx.Text), id.ToString(), sdtAdyTxBx.Text);
							_mw.PassStudent(_myStudent);
							_mw.State = true;
							this.Close();
						}
						catch
						{
							birthEro.Visible = true;
						}							
					}
					else
					{
						adyEro.Visible = true;
					}
				}
				else
				{
					idEro.Visible = true;
				}
			}
			else
			{
				nameEro.Visible = true;
			}
		}
		
		private void SdtCnlBtnClick(object sender, EventArgs e)
		{
			_mw.State = false;
			this.Close();
		}






		//	Methods for watermark text in texboxes
		public void NameGotFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "Joe Dow") { tb.Text = ""; tb.ForeColor = Color.Black; }
		}
		public void NameLostFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "") { tb.Text = "Joe Dow"; tb.ForeColor = Color.LightGray; }
		}
		public void BirthdayGotFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "dd/mm/yyyy") { tb.Text = ""; tb.ForeColor = Color.Black; }
		}
		public void BirthdayLostFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "") { tb.Text = "dd/mm/yyyy"; tb.ForeColor = Color.LightGray; }
		}
		public void IdGotFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "12345678") { tb.Text = ""; tb.ForeColor = Color.Black; }
		}
		public void IdLostFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "") { tb.Text = "12345678"; tb.ForeColor = Color.LightGray; }
		}
		public void AddressGotFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "123 Upto Street") { tb.Text = ""; tb.ForeColor = Color.Black; }
		}
		public void AddressLostFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "") { tb.Text = "123 Upto Street"; tb.ForeColor = Color.LightGray; }
		}
	}
}
