namespace UnityEngine.Rendering.Universal;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RenderTargetHandle
{
	public static readonly RenderTargetHandle CameraTarget; //Field offset: 0x0
	[CompilerGenerated]
	private int <id>k__BackingField; //Field offset: 0x0

	public int id
	{
		[CompilerGenerated]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	private static RenderTargetHandle() { }

	public bool Equals(RenderTargetHandle other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public int get_id() { }

	public virtual int GetHashCode() { }

	public RenderTargetIdentifier Identifier() { }

	public void Init(string shaderProperty) { }

	[CompilerGenerated]
	public void set_id(int value) { }

}

