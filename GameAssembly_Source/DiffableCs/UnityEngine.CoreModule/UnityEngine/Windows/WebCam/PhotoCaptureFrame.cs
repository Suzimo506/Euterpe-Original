namespace UnityEngine.Windows.WebCam;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class PhotoCaptureFrame : IDisposable
{
	private IntPtr m_NativePtr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <dataLength>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <hasLocationData>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CapturePixelFormat <pixelFormat>k__BackingField; //Field offset: 0x20

	public private int dataLength
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private bool hasLocationData
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private CapturePixelFormat pixelFormat
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal PhotoCaptureFrame(IntPtr nativePtr) { }

	private void Cleanup() { }

	public override void Dispose() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ThreadAndSerializationSafe]
	private void Dispose_Internal() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public int get_dataLength() { }

	[ThreadAndSerializationSafe]
	private CapturePixelFormat GetCapturePixelFormat() { }

	[ThreadAndSerializationSafe]
	private int GetDataLength() { }

	[ThreadAndSerializationSafe]
	private bool GetHasLocationData() { }

	[CompilerGenerated]
	private void set_dataLength(int value) { }

	[CompilerGenerated]
	private void set_hasLocationData(bool value) { }

	[CompilerGenerated]
	private void set_pixelFormat(CapturePixelFormat value) { }

}

