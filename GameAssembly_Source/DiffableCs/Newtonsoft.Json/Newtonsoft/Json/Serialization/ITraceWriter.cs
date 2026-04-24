namespace Newtonsoft.Json.Serialization;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface ITraceWriter
{

	public TraceLevel LevelFilter
	{
		 get { } //Length: 0
	}

	public TraceLevel get_LevelFilter() { }

	public void Trace(TraceLevel level, string message, Exception ex) { }

}

