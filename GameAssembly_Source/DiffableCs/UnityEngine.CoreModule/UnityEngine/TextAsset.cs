namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TextAsset : object
{
	public enum CreateOptions
	{
		None = 0,
		CreateNativeObject = 1,
	}


	public Byte[] bytes
	{
		 get { } //Length: 51
	}

	public string text
	{
		 get { } //Length: 51
	}

	public TextAsset() { }

	public TextAsset(string text) { }

	internal TextAsset(CreateOptions options, string text) { }

	public Byte[] get_bytes() { }

	public string get_text() { }

	private static void Internal_CreateInstance(TextAsset self, string text) { }

	public virtual string ToString() { }

}

