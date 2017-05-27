using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_212
{
	public class Student
	{
		private string _sdtName;
		private DateTime _birthday;
		private string _id;
		private string _address;
		private List<Paper> _enrolledPapers;

		//	Constructor
		public Student(string name, DateTime birthday, string id, string address, List<Paper> enrolledPapers = null)
		{
			if (name != null && birthday != null && id != null && address != null)
			{
				_sdtName = name;
				_birthday = birthday;
				_id = id;
				_address = address;
				if (enrolledPapers != null)
				{
					_enrolledPapers = enrolledPapers;
				}
				else
				{
					_enrolledPapers = new List<Paper>();
				}
			}
		}

		//	Getters
		public string Name { get { return _sdtName; } }
		public DateTime Birthday { get { return _birthday; } }
		public string Id { get { return _id; } }
		public string Address { get { return _address; } }
		public List<Paper> EnrolledPapers {	get { return _enrolledPapers; }	}
		
	}
}
