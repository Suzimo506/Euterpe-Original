namespace UnityEngine.Rendering;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ReloadAttribute : Attribute
{
	internal enum Package
	{
		Builtin = 0,
		Root = 1,
	}


	public ReloadAttribute(String[] paths, Package package = 1) { }

	public ReloadAttribute(string path, Package package = 1) { }

	public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = 1) { }

}

