namespace UnityEngine.Playables;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class PlayableDirector : Behaviour
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Action<PlayableDirector> played; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Action<PlayableDirector> paused; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Action<PlayableDirector> stopped; //Field offset: 0x28

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorStop() { }

}

