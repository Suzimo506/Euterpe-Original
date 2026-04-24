namespace System.Reflection;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ManifestResourceInfo
{
	private Assembly _containingAssembly; //Field offset: 0x10
	private string _containingFileName; //Field offset: 0x18
	private ResourceLocation _resourceLocation; //Field offset: 0x20

	public override string FileName
	{
		 get { } //Length: 5
	}

	public override Assembly ReferencedAssembly
	{
		 get { } //Length: 5
	}

	public override ResourceLocation ResourceLocation
	{
		 get { } //Length: 4
	}

	public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	public override string get_FileName() { }

	public override Assembly get_ReferencedAssembly() { }

	public override ResourceLocation get_ResourceLocation() { }

}

