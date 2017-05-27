using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_212
{
	public class University
	{
		private List<Paper> _uniPapers;
		private List<Student> _uniStudents;		

		public University(List<Paper> pList = null, List<Student> sList = null)
		{
			if (sList != null)
			{
				_uniStudents = sList;
			}
			else
			{
				_uniStudents = new List<Student>();
			}
			if (pList != null)
			{
				_uniPapers = pList;
			}
			else
			{
				_uniPapers = new List<Paper>();
			}
		}
		
		//	Getters
		public List<Student> Student { get { return _uniStudents; } }
		public List<Paper> Paper { get { return _uniPapers; } }

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
