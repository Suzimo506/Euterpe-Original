namespace UnityEngine;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ColorUsageAttribute : PropertyAttribute
{
	public readonly bool showAlpha; //Field offset: 0x10
	public readonly bool hdr; //Field offset: 0x11
	[Obsolete]
	public readonly float minBrightness; //Field offset: 0x14
	[Obsolete]
	public readonly float maxBrightness; //Field offset: 0x18
	[Obsolete]
	public readonly float minExposureValue; //Field offset: 0x1C
	[Obsolete]
	public readonly float maxExposureValue; //Field offset: 0x20

	public ColorUsageAttribute(bool showAlpha) { }

}

