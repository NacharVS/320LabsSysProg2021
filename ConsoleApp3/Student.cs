using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
		public delegate void GroupChangedDelegate(string message);
        public string Name { get; set; }
		private int _group;

		public int Group
		{
			get { return _group; }
			set 
			{ 
				_group = value;
				GroupChandgedEvent?.Invoke("Value has changed");				
			}
		}

		public event GroupChangedDelegate GroupChandgedEvent;
	}
}
