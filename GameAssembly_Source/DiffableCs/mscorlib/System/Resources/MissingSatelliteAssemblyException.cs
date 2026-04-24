namespace System.Resources;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class MissingSatelliteAssemblyException : SystemException
{
	private string _cultureName; //Field offset: 0x88

	public MissingSatelliteAssemblyException() { }

	public MissingSatelliteAssemblyException(string message, string cultureName) { }

	protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context) { }

}

