namespace UnityEngine.Playables;

[Extension]
public static class PlayableExtensions
{

	[Extension]
	public static Playable GetInput(U playable, int inputPort) { }

	[Extension]
	public static int GetInputCount(U playable) { }

	[Extension]
	public static bool IsNull(U playable) { }

	[Extension]
	public static void SetTime(U playable, double value) { }

}

