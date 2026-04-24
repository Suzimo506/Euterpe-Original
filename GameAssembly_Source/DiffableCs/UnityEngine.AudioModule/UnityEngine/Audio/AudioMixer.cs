namespace UnityEngine.Audio;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class AudioMixer : object
{

	[NativeMethod]
	public bool GetFloat(string name, out float value) { }

	[NativeMethod]
	public bool SetFloat(string name, float value) { }

}

