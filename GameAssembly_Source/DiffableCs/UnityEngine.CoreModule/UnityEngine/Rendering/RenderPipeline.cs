namespace UnityEngine.Rendering;

public abstract class RenderPipeline
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <disposed>k__BackingField; //Field offset: 0x10

	public private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal void Dispose() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	public bool get_disposed() { }

	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

