using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_5_212;

namespace Assignment_5_Unit_Tests
{
	[TestClass]
	public class UnitTest1
	{
		private MainWin mw = new MainWin();
		private Student s1 = new Student("Leonard", Convert.ToDateTime("12/10/1990"), "1782", "sjkhs");
		private Paper p1 = new Paper("Software", "9089", "Joe");
		private Paper p2 = new Paper("Software", "9089", "Joe");
		private University u1 = new University();
		private University u2 = new University();

		[TestMethod]
		public void LogicCheck_Student_ValidatingJToken_Method()
		{
			int expected = 1;
			int actual = mw.ValidatingJToken(s1);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void LogicCheck_Paper_ValidatingJToken_Method()
		{
			int expected = 1;
			int actual = mw.ValidatingJToken(null, p1);

			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void LogicCheck_RemoveDoublePaper_Method()
		{
			
			u2.Student.Add(s1);
			u2.Student[0].EnrolledPapers.Add(p2);
			u1.Paper.Add(p1);

			mw.ValidateStudentPaperEnrollment(u2, u1);

			int expected = 0;
			int actual = u2.Student[0].EnrolledPapers.Count;

			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void LogicCheck_AlreadyEnrolled_Method()
		{
			u1.Student.Add(s1);
			u1.Student[0].EnrolledPapers.Add(p1);

			bool expected = false;
			bool actual = mw.AlreadyEnrolled(u1.Student[0], p1);

			Assert.AreEqual(expected, actual);
		}
	}
}
