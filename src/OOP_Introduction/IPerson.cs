using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction
{
	// Interface which can be implemented by classes
	// Every class that implements IPerson must have the properties and methods listed below
	public interface IPerson
	{
		string Name { get; set; }

		int Age { get; set; }

		Gender Gender { get; set; }
	}
}
