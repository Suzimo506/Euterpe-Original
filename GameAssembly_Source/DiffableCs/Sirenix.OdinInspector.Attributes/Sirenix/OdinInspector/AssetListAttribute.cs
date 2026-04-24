namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class AssetListAttribute : Attribute
{
	public bool AutoPopulate; //Field offset: 0x10
	public string Tags; //Field offset: 0x18
	public string LayerNames; //Field offset: 0x20
	public string AssetNamePrefix; //Field offset: 0x28
	public string Path; //Field offset: 0x30
	public string CustomFilterMethod; //Field offset: 0x38

	public AssetListAttribute() { }

}

