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
	public partial class PaperAddWin : Form
	{
		MainWin _mw;
		public PaperAddWin(MainWin mw)
		{
			InitializeComponent();
			this._mw = mw;



			//	Event handlers for watermark text in textboxes
			papNmeTxBx.GotFocus += new EventHandler(this.NameGotFocus);
			papNmeTxBx.LostFocus += new EventHandler(this.NameLostFocus);
			papCodeTxBx.GotFocus += new EventHandler(this.CodeGotFocus);
			papCodeTxBx.LostFocus += new EventHandler(this.CodeLostFocus);
			papCoordTxBx.GotFocus += new EventHandler(this.CoordGotFocus);
			papCoordTxBx.LostFocus += new EventHandler(this.CoordLostFocus);
		}

		private void PapCfmBtnClick(object sender, EventArgs e)
		{
			if (papNmeTxBx.Text != "Joe Dow")
			{
				nameEro.Visible = false;
				if (Int32.TryParse(papCodeTxBx.Text, out int code) && papCodeTxBx.Text != "1234")
				{
					codeEro.Visible = false;
					if (papCoordTxBx.Text != "Jone Jones")
					{
						coordEro.Visible = false;
						Paper myPaper = new Paper(papNmeTxBx.Text, code.ToString(), papCoordTxBx.Text);
						_mw.PassPaper(myPaper);
						_mw.State = true;
						this.Close();
					}
					else
					{	
						coordEro.Visible = true;
					}
				}
				else
				{					
					codeEro.Visible = true;
				}
			}
			else
			{
				nameEro.Visible = true;
			}
		}

		private void PapCnlBtnClick(object sender, EventArgs e)
		{
			_mw.State = false;
			this.Close();
		}




		//	Methods for watermark text in texboxes
		public void NameGotFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "Joe Dow"){ tb.Text = ""; tb.ForeColor = Color.Black; }
		}
		public void NameLostFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == ""){ tb.Text = "Joe Dow"; tb.ForeColor = Color.LightGray; }
		}
		public void CodeGotFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "1234") { tb.Text = ""; tb.ForeColor = Color.Black; }
		}
		public void CodeLostFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "") { tb.Text = "1234"; tb.ForeColor = Color.LightGray; }
		}
		public void CoordGotFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "Jone Jones") { tb.Text = ""; tb.ForeColor = Color.Black; }
		}
		public void CoordLostFocus(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			if (tb.Text == "") { tb.Text = "Jone Jones"; tb.ForeColor = Color.LightGray; }
		}
	}
}
