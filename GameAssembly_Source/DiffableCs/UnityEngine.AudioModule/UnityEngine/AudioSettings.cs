namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class AudioSettings
{
	internal sealed class AudioConfigurationChangeHandler : MulticastDelegate
	{

		public AudioConfigurationChangeHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool deviceWasChanged) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; //Field offset: 0x6B4FE

	public static AudioConfiguration GetConfiguration() { }

	private static void GetConfiguration_Injected(out AudioConfiguration ret) { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	public static bool Reset(AudioConfiguration config) { }

	[NativeMethod]
	[NativeThrows]
	private static bool SetConfiguration(AudioConfiguration config) { }

	private static bool SetConfiguration_Injected(ref AudioConfiguration config) { }

}

