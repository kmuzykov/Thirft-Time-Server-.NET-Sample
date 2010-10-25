using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift;
using Thrift.Server;
using Thrift.Transport;
using TimeServer.Thrift;

namespace TimeServer
{
	class Program
	{
		static void Main(string[] args)
		{
			TimeServiceImplementation service = new TimeServiceImplementation();
			TProcessor processor = new TimeService.Processor(service);
			TServerTransport transport = new TServerSocket(1337, 1000);
			TServer server = new TSimpleServer(processor, transport);

			server.Serve();
		}
	}
}
