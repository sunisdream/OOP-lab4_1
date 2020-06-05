using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Lab04___1___Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			string name = "Mike";
			string lastName = "Wazowsky";
			string group = "KN-101";
			int year = 2017;
			string address = "vul. Mazepy";
			int passport = 22748391;
			int age = 19;
			int telephone = 0674829310;
			int rating = 89;

			Student student = new Student();
			student.SetName(name);
			student.SetLastName(lastName);
			student.SetGroup(group);
			student.SetYear(year);
			student.SetAddress(address);
			student.SetPassport(passport);
			student.SetAge(age);
			student.SetTelephone(telephone);
			student.SetRating(rating);

			using (StringWriter sw = new StringWriter())
			{
				Console.SetOut(sw);
				student.StudentRating(student.GetRating());

				string expected = "Можна вчитися краще\r\n";
				string actual = sw.ToString();
				Assert.AreEqual<string>(expected, actual);
			}
		}
	}
}
