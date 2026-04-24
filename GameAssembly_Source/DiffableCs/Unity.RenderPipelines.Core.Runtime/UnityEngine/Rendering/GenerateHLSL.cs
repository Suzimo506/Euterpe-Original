namespace UnityEngine.Rendering;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GenerateHLSL : Attribute
{
	public PackingRules packingRules; //Field offset: 0x10
	public bool containsPackedFields; //Field offset: 0x14
	public bool needAccessors; //Field offset: 0x15
	public bool needSetters; //Field offset: 0x16
	public bool needParamDebug; //Field offset: 0x17
	public int paramDefinesStart; //Field offset: 0x18
	public bool omitStructDeclaration; //Field offset: 0x1C

	public GenerateHLSL(PackingRules rules = 0, bool needAccessors = true, bool needSetters = false, bool needParamDebug = false, int paramDefinesStart = 1, bool omitStructDeclaration = false, bool containsPackedFields = false) { }

}

