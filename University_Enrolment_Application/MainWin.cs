using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;


namespace Assignment_5_212
{
	public partial class MainWin : Form
	{
		University _myUniversity = new University();
		Student _myStudent;
		Paper _myPaper;

		public MainWin()
		{
			InitializeComponent();
		}
		private void SdtAddBtnClick(object sender, EventArgs e)
		{
			StudentAddWin saw = new StudentAddWin(this);
			saw.ShowDialog();
			if (State == true)
			{
				_myUniversity.AddSudent(_myStudent);
				studentListBx.Items.Add(_myStudent.Name + " " + _myStudent.Id);
			}
		}
		private void PapAddBtnClick(object sender, EventArgs e)
		{
			PaperAddWin paw = new PaperAddWin(this);
			paw.ShowDialog();
			if (State == true)
			{
				_myUniversity.AddPaper(_myPaper);
				paperListBx.Items.Add(_myPaper.Name + " " + _myPaper.Code);
			}
		}
		private void PaperDplyBtnClick(object sender, EventArgs e)
		{
			if (studentListBx.SelectedIndex != -1)
			{
				StudentInfoWin siw = new StudentInfoWin(_myUniversity, NameFromListBxIndex(studentListBx));
				siw.ShowDialog();
			}
		}
		private void StudentDplyBtnClick(object sender, EventArgs e)
		{
			if (paperListBx.SelectedIndex != -1)
			{
				PaperInfoWin piw = new PaperInfoWin(_myUniversity, NameFromListBxIndex(paperListBx));
				piw.ShowDialog();
			}
		}
		private void EnrolBtnClick(object sender, EventArgs e)
		{
			if (studentListBx.SelectedIndex != -1 && paperListBx.SelectedIndex != -1)
			{
				_myStudent = _myUniversity.SelectStudent(NameFromListBxIndex(studentListBx));
				_myPaper = _myUniversity.SelectPaper(NameFromListBxIndex(paperListBx));

				_myUniversity.SelectPaper(NameFromListBxIndex(paperListBx)).StudentName.Add(_myStudent.Name);
				_myUniversity.SelectStudent(NameFromListBxIndex(studentListBx)).EnrolledPapers.Add(_myPaper.Name);
			}
		}

		public void PassStudent(Student aStudent) { this._myStudent = aStudent; }
		public void PassPaper(Paper aPaper) { this._myPaper = aPaper; }
		public bool State { get; set; }

		public string NameFromListBxIndex(ListBox lb)
		{
			string n = lb.SelectedItem.ToString();
			string fw = n.Substring(0, n.IndexOf(" "));
			return fw;
		}
		/*
		private void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{			
			SaveFileDialog sfd = new SaveFileDialog()
			{
				Filter = "Text files (*.txt)|*.txt"
			};
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter(sfd.OpenFile()))
				{
					foreach (Student s in _myUniversity.Student)
					{
						sw.WriteLine(s.Name);
						sw.WriteLine(s.Birthday.ToShortDateString());
						sw.WriteLine(s.Id);						
						sw.WriteLine(s.Address);
						sw.WriteLine(s.ConcatPapers());
					}
					sw.WriteLine(" ");
					foreach (Paper p in _myUniversity.Paper)
					{
						sw.WriteLine(p.Name);
						sw.WriteLine(p.Code);
						sw.WriteLine(p.Coordinater);
						sw.WriteLine(p.ConcatStudents());
					}
				}
			}
		}

		private void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			//{
			//	Filter = "Text files (*.txt)|*.txt"
			//};
			State = true;
			while (State)
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					using (StreamReader sr = new StreamReader(ofd.OpenFile()))
					{
						try
						{
							while (true)
							{
								if (sr.ReadLine() != " ")
								{
									Student s = new Student(sr.ReadLine(), Convert.ToDateTime(sr.ReadLine()), int.Parse(sr.ReadLine()).ToString(), sr.ReadLine());
								}
							}
							State = false;
						}
						catch
						{
							MessageBox.Show("Invalid file content");
						}

					}
				}
				else
				{
					State = false;
				}
			}
		}
		*/
		
		/// <summary>
		///		Unsure whether to write in json format.
		///		I am unsure how to read json data back into the program and how to prevent any duplicate data from being added.
		/// </summary>

		private void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFileDialog f = new SaveFileDialog()
			{
				Filter = "Json files (*.json)|*.json"
			};
			if (f.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter(f.OpenFile()))
				{
					JsonSerializer serializer = new JsonSerializer();
					serializer.Serialize(sw, _myUniversity);
				}
			}
		}

		private void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog f = new OpenFileDialog()
			{
				Filter = "Json files (*.json)|*.json"
			};
			if (f.ShowDialog() == DialogResult.OK)
			{
				string JSON = File.ReadAllText(f.FileName);
				JavaScriptSerializer j = new JavaScriptSerializer();
				object text = j.DeserializeObject(JSON);



			}
		}
	}
}
