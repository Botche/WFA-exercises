﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction
{
	public interface IPerson
	{
		string Name { get; set; }

		int Age { get; set; }

		Gender Gender { get; set; }
	}
}