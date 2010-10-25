using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift;
using Thrift.Transport;
using Thrift.Protocol;
using TimeServer.Thrift;


namespace TimeServerClient
{
	class Program
	{
		static void Main(string[] args)
		{
			TTransport transport = new TSocket("localhost", 1337);
			TProtocol proto = new TBinaryProtocol(transport);
			TimeService.Client client = new TimeService.Client(proto);

			transport.Open();

			Console.WriteLine(client.GetTime());
			Console.ReadKey();
		}
	}
}
