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

		//	Constructor
		public Paper(string name, string code, string coordinater)
		{
			if (name != null && code != null && coordinater != null)
			{
				this._papName = name;
				this._code = code;
				this._coordinater = coordinater;
			}
		}

		//	Getters
		public string Name { get { return _papName; } }
		public string Code { get { return _code; } }
		public string Coordinater { get { return _coordinater; } }
	}
}
