namespace UnityEngine;

[Extension]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class ImageConversion
{

	[Extension]
	[NativeMethod]
	public static Byte[] EncodeToPNG(Texture2D tex) { }

	[Extension]
	[NativeMethod]
	public static bool LoadImage(Texture2D tex, Byte[] data, bool markNonReadable) { }

}

