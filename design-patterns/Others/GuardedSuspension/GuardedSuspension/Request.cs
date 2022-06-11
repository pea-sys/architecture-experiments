using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardedSuspension
{
    internal class Request
    {
		private readonly string name;
		public string Name => name;

		public Request(string name)
		{
			this.name = name;
		}

		public override string ToString()
		{
			return $"[ Request {name} ]";
		}
	}
}
