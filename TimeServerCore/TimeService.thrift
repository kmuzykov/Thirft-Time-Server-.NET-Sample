namespace csharp TimeServer.Thrift

struct TimeInfoStruct{
1: string Time
}

service TimeService
{
	TimeInfoStruct GetTime()
}
