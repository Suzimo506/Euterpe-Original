namespace UnityEngine.Profiling;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public sealed class CustomSampler : Sampler
{
	internal static CustomSampler s_InvalidCustomSampler; //Field offset: 0x6B43C

	private static CustomSampler() { }

	internal CustomSampler() { }

	internal CustomSampler(IntPtr ptr) { }

	public static CustomSampler Create(string name) { }

	[NativeMethod]
	private static IntPtr CreateInternal(string name) { }

}

