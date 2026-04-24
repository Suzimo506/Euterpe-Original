namespace UnityEngine.Rendering;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class HLSLArray : Attribute
{
	public int arraySize; //Field offset: 0x10
	public Type elementType; //Field offset: 0x18

	public HLSLArray(int arraySize, Type elementType) { }

}

