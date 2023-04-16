using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Person> list = new List<Person>()
			{ new Employee{Name ="A"},
			 new Employee {Name ="B",Salary = 100} };

			foreach (Person person in list)
			{

				//Console.WriteLine(person.GetMessage());
				person.GetMessage();
			}
			Console.ReadLine();
		}
	}
	public abstract class Person
	{
		public string Name { get; set; }
		public abstract void GetMessage();
		//{
		//	return $"{Name}";
		//}
    }
	public class Employee : Person
	{
		public int Salary { get; set; }
		public override void GetMessage()
		{
			 throw new NotFiniteNumberException();
			//return $"{Name},{Salary}";
		}
	}

}
