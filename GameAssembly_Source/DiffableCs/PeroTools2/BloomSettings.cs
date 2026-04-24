//Type is in global namespace

public class BloomSettings
{
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float intensity; //Field offset: 0x10
	[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float threshold; //Field offset: 0x14
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float blurScale; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool extraIteration; //Field offset: 0x1C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool extraDetail; //Field offset: 0x1D
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool extraBloom; //Field offset: 0x1E
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string emissivePass; //Field offset: 0x20

	public BloomSettings() { }

}

