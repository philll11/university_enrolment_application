using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_212
{
	public class Paper
	{
		private string _papName;
		private string _code;
		private string _coordinater;
		private List<string> _studentNames = new List<string>();

		//	Constructor
		public Paper(string aName, string aCode, string aCoor)
		{
			this._papName = aName;
			this._code = aCode;
			this._coordinater = aCoor;
		}

		//	Getters
		public string Name { get { return _papName; } }
		public string Code { get { return _code; } }
		public string Coordinater { get { return _coordinater; } }
		public List<string> StudentName { get { return _studentNames; } set { _studentNames.Add(value.ToString()); } }
		public string ConcatStudents()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < _studentNames.Count; i++)
			{
				sb.Append(_studentNames[i]);
				sb.Append(" ");
			}
			return sb.ToString();
		}
	}
}
