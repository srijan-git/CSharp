using System;
namespace Fundamentals
{
	public class Food
	{
		public virtual void eat()
		{
			Console.WriteLine("Eating....");
		}
	}
	public class MethodOverriding:Food
	{
		public override void eat() {

            Console.WriteLine("Eating Bread....");
        }
	}
}

