namespace UnityEngine.PostProcessing;

public sealed class GetSetAttribute : PropertyAttribute
{
	public readonly string name; //Field offset: 0x10
	public bool dirty; //Field offset: 0x18

	public GetSetAttribute(string name) { }

}

