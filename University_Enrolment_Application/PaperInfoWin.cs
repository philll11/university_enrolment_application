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
	public partial class PaperInfoWin : Form
	{
		public PaperInfoWin(University uni, string name)
		{
			InitializeComponent();
			Paper p = uni.SelectPaper(name);
			nameLbl.Text = p.Name;
			idLbl.Text = p.Code;
			coordLbl.Text = p.Coordinater;


			foreach (Student s in uni.Student)
			{
				foreach (Paper paper in s.EnrolledPapers)
				{
					if (paper.Name == name)
					{
						studentListBx.Items.Add(s.Name);
						
					}
				}
			}

		}

		private void SdtInforCnlBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}



	}
}
