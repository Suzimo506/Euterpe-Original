namespace Unity.Collections;

public static class NativeLeakDetection
{
	private static int s_NativeLeakDetectionMode; //Field offset: 0x6B35A

	[RuntimeInitializeOnLoadMethod]
	private static void Initialize() { }

}

