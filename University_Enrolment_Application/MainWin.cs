using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
				_myUniversity.Student.Add(_myStudent);
				studentListBx.Items.Add(_myStudent.Name + " " + _myStudent.Id);
			}
		}
		private void PapAddBtnClick(object sender, EventArgs e)
		{
			PaperAddWin paw = new PaperAddWin(this);
			paw.ShowDialog();
			if (State == true)
			{
				
				_myUniversity.Paper.Add(_myPaper);
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
		private void EnrollmentBtnClick(object sender, EventArgs e)
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
				if (AlreadyEnrolled(_myStudent, _myPaper))
				{
					enrollmentErrorLbl.Visible = false;
					_myUniversity.SelectStudent(NameFromListBxIndex(studentListBx)).EnrolledPapers.Add(_myPaper);
				}
				else
				{
					enrollmentErrorLbl.Visible = true;
				}
			}
		}
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
				University newUniversity = JsonConvert.DeserializeObject<University>(JSON);

				//	Use schema to validate the input coming in.

				if (ValidatePapers(newUniversity, _myUniversity))
				{
					UpdatePaperListBox(_myUniversity.Paper, paperListBx);
				}
				if (ValidateStudents(newUniversity, _myUniversity))
				{
					ValidateStudentPaperEnrollment(newUniversity, _myUniversity);
					UpdateStudentListBox(_myUniversity.Student, studentListBx);
				}
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

		public bool AlreadyEnrolled(Student s, Paper p)
		{
			foreach (Paper exists in s.EnrolledPapers)
			{
				if (exists.Name == p.Name)
				{
					return false;
				}
			}
			return true;
		}

		public int ValidatingJToken(Student s, Paper p = null)
		{
			if (s != null)
			{
				if (s.Name == null)
				{
					return -1;
				}
				return 1;
			}
			if (p != null)
			{
				if (p.Name == null)
				{
					return -1;
				}
				return 1;
			}
			return -1;
		}

		public bool ValidateStudents(University newUniversity, University oldUniversity)
		{
			State = false;
			int limit = oldUniversity.Student.Count;
			foreach (Student newStudent in newUniversity.Student)
			{
				if (ValidatingJToken(newStudent) == 1)
				{
					if (limit != 0)
					{
						for (int i = 0; i < limit; i++)
						{
							if (oldUniversity.Student[i].Id != newStudent.Id)
							{
								oldUniversity.Student.Add(newStudent);
								State = true;
							}
						}
					}
					else
					{
						oldUniversity.Student.Add(newStudent);
						State = true;
					}
				}
			}
			return State;
		}

		public bool ValidatePapers(University newUniversity, University oldUniversity)
		{
			State = false;
			int limit = oldUniversity.Paper.Count;
			foreach (Paper newPaper in newUniversity.Paper)
			{
				if (ValidatingJToken(null, newPaper) == 1)
				{
					if (limit != 0)
					{
						for (int i = 0; i < limit; i++)
						{
							if (oldUniversity.Paper[i].Code != newPaper.Code)
							{
								oldUniversity.Paper.Add(newPaper);
								State = true;
							}
						}
					}
					else
					{
						oldUniversity.Paper.Add(newPaper);
						State = true;
					}
				}
			}
			return State;
		}

		//	Removes any papers the student is enroled in that don't exist in the current University.
		public void ValidateStudentPaperEnrollment(University newUniversity, University oldUniversity)
		{
			foreach (Student s in newUniversity.Student)
			{
				int count = s.EnrolledPapers.Count;
				int i = 0;
				while (count > i)
				{					
					foreach (Paper p in oldUniversity.Paper)
					{
						if (s.EnrolledPapers[i] != p)
						{
							s.EnrolledPapers.RemoveAt(i);
							count--;
						}
					}
					i++;
				}
			}
		}
		
		public void UpdateStudentListBox(List<Student> students, ListBox lb)
		{
			foreach (Student s in students)
			{
				lb.Items.Add(s.Name + " " + s.Id);
			}
		}

		public void UpdatePaperListBox(List<Paper> papers, ListBox lb)
		{
			foreach (Paper p in papers)
			{
				lb.Items.Add(p.Name + " " + p.Code);
			}
		}
	}
}
