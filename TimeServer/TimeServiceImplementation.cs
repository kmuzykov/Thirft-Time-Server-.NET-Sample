using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeServer.Thrift;

namespace TimeServer
{
	class TimeServiceImplementation : TimeService.Iface
	{
		public TimeInfoStruct GetTime()
		{
			return new TimeInfoStruct()
			{
				Time = DateTime.Now.ToString()
			};
		}
	}
}
