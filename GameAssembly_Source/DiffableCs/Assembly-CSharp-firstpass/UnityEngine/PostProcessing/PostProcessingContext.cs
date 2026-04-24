namespace UnityEngine.PostProcessing;

public class PostProcessingContext
{
	public PostProcessingProfile profile; //Field offset: 0x10
	public Camera camera; //Field offset: 0x18
	public MaterialFactory materialFactory; //Field offset: 0x20
	public RenderTextureFactory renderTextureFactory; //Field offset: 0x28
	[CompilerGenerated]
	private bool <interrupted>k__BackingField; //Field offset: 0x30

	public int height
	{
		 get { } //Length: 29
	}

	public private bool interrupted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool isGBufferAvailable
	{
		 get { } //Length: 36
	}

	public bool isHdr
	{
		 get { } //Length: 29
	}

	public Rect viewport
	{
		 get { } //Length: 51
	}

	public int width
	{
		 get { } //Length: 29
	}

	public PostProcessingContext() { }

	public int get_height() { }

	[CompilerGenerated]
	public bool get_interrupted() { }

	public bool get_isGBufferAvailable() { }

	public bool get_isHdr() { }

	public Rect get_viewport() { }

	public int get_width() { }

	public void Interrupt() { }

	public PostProcessingContext Reset() { }

	[CompilerGenerated]
	private void set_interrupted(bool value) { }

}

