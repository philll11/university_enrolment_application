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
	public partial class StudentInfoWin : Form
	{
		public StudentInfoWin(University uni, string name)
		{
			InitializeComponent();
			
			Student s = uni.SelectStudent(name);
			foreach (Paper p in s.EnrolledPapers)
			{
				papersListBx.Items.Add(p.Name);
			}
			nameLbl.Text = s.Name;
			idLbl.Text = s.Id;
			birthLbl.Text = s.Birthday.ToString("dd/MM/yyyy");
			adyLbl.Text = s.Address;
		}

		private void SdtInforCnlBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
