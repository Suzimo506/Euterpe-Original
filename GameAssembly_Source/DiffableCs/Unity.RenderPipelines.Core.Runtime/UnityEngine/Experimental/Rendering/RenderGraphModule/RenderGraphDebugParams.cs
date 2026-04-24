namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class RenderGraphDebugParams
{
	public bool enableRenderGraph; //Field offset: 0x10
	public bool tagResourceNamesWithRG; //Field offset: 0x11
	public bool clearRenderTargetsAtCreation; //Field offset: 0x12
	public bool clearRenderTargetsAtRelease; //Field offset: 0x13
	public bool unbindGlobalTextures; //Field offset: 0x14
	public bool logFrameInformation; //Field offset: 0x15
	public bool logResources; //Field offset: 0x16

	public RenderGraphDebugParams() { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__7_0() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__7_1(bool value) { }

	[CompilerGenerated]
	private void <RegisterDebug>b__7_10() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__7_11() { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__7_2() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__7_3(bool value) { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__7_4() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__7_5(bool value) { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__7_6() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__7_7(bool value) { }

	[CompilerGenerated]
	private bool <RegisterDebug>b__7_8() { }

	[CompilerGenerated]
	private void <RegisterDebug>b__7_9(bool value) { }

	public void RegisterDebug() { }

	public void UnRegisterDebug() { }

}

