namespace UnityEngine.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class FormerlySerializedAsAttribute : Attribute
{
	private string m_oldName; //Field offset: 0x10

	public string oldName
	{
		 get { } //Length: 7
	}

	public FormerlySerializedAsAttribute(string oldName) { }

	public string get_oldName() { }

}

