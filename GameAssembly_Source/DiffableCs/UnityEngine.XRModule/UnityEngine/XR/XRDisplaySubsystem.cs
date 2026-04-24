namespace UnityEngine.XR;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeType]
[UsedByNativeCode]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal struct XRMirrorViewBlitDesc
	{
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		public bool nativeBlitAvailable; //Field offset: 0x8
		public bool nativeBlitInvalidStates; //Field offset: 0x9
		public int blitParamsCount; //Field offset: 0xC

	}

	[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal struct XRRenderPass
	{
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		public int renderPassIndex; //Field offset: 0x8
		public RenderTargetIdentifier renderTarget; //Field offset: 0x10
		public RenderTextureDescriptor renderTargetDesc; //Field offset: 0x38
		public bool shouldFillOutDepth; //Field offset: 0x6C
		public int cullingPassIndex; //Field offset: 0x70

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<Boolean> displayFocusChanged; //Field offset: 0x6B54C

	public XRDisplaySubsystem() { }

	[RequiredByNativeCode]
	private static void InvokeDisplayFocusChanged(bool focus) { }

}

