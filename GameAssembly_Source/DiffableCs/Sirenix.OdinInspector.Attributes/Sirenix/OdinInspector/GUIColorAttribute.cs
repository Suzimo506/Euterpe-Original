namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GUIColorAttribute : Attribute
{
	public Color Color; //Field offset: 0x10
	public string GetColor; //Field offset: 0x20

	public GUIColorAttribute(float r, float g, float b, float a = 1) { }

	public GUIColorAttribute(string getColor) { }

}

