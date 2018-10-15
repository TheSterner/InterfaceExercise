using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
	public class Employee : Person , IQuittable
	{
		public override void SayName()
		{
			foreach (string name in FirstName)
			{
				foreach (string lname in LastName)
				{
					Console.WriteLine("Name: " + name + " " + lname);

				}


			}
		}
		public void Quit(Person person)
		{
			throw new NotImplementedException();
		}
	}
}
