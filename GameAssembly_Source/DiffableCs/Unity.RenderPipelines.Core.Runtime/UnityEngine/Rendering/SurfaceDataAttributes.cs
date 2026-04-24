namespace UnityEngine.Rendering;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SurfaceDataAttributes : Attribute
{
	public String[] displayNames; //Field offset: 0x10
	public bool isDirection; //Field offset: 0x18
	public bool sRGBDisplay; //Field offset: 0x19
	public FieldPrecision precision; //Field offset: 0x1C

	public SurfaceDataAttributes(string displayName = "", bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = 2) { }

	public SurfaceDataAttributes(String[] displayNames, bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = 2) { }

}

