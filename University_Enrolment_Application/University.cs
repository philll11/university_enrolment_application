using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_212
{
	public class University
	{
		private List<Student> _uniStudents = new List<Student>();
		private List<Paper> _uniPapers = new List<Paper>();
		
		//	Getters
		public List<Student> Student { get { return _uniStudents; } }
		public List<Paper> Paper { get { return _uniPapers; } }

		//	Adders
		public void AddSudent(Student s) { this._uniStudents.Add(s); }
		public void AddPaper(Paper p) { this._uniPapers.Add(p);	}

		public Student SelectStudent(string aName)
		{
			foreach (Student s in _uniStudents)
			{
				if (s.Name == aName)
				{
					return s;
				}
			}
			return null;
		}
		public Paper SelectPaper(string aName)
		{
			foreach (Paper p in _uniPapers)
			{
				if (p.Name == aName)
				{
					return p;
				}
			}
			return null;
		}
	}
}
