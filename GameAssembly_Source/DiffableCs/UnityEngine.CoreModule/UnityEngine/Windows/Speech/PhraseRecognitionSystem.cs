namespace UnityEngine.Windows.Speech;

public static class PhraseRecognitionSystem
{
	internal sealed class ErrorDelegate : MulticastDelegate
	{

		public ErrorDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SpeechError errorCode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SpeechError errorCode) { }

	}

	internal sealed class StatusDelegate : MulticastDelegate
	{

		public StatusDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SpeechSystemStatus status, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SpeechSystemStatus status) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static ErrorDelegate OnError; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static StatusDelegate OnStatusChanged; //Field offset: 0x8

	[RequiredByNativeCode]
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCode]
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }

}

