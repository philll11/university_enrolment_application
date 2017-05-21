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
		private List<string> _enrolledPapers = new List<string>();

		//	Constructor
		public Student(string name, DateTime birthday, string id, string address)
		{
			_sdtName = name;
			_birthday = birthday;
			_id = id;
			_address = address;
		}

		//	Getters
		public string Name { get { return _sdtName; } }
		public DateTime Birthday { get { return _birthday; } }
		public string Id { get { return _id; } }
		public string Address { get { return _address; } }
		public List<string> EnrolledPapers { get { return _enrolledPapers; } set { _enrolledPapers.Add(value.ToString()); } }
		public string ConcatPapers()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < _enrolledPapers.Count; i++)
			{
				sb.Append(_enrolledPapers[i]);
				sb.Append(" ");
			}
			return sb.ToString();
		}
	}
}
