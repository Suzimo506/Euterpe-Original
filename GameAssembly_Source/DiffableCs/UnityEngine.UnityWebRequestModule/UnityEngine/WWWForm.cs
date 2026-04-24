namespace UnityEngine;

public class WWWForm
{
	private List<Byte[]> formData; //Field offset: 0x10
	private List<String> fieldNames; //Field offset: 0x18
	private List<String> fileNames; //Field offset: 0x20
	private List<String> types; //Field offset: 0x28
	private Byte[] boundary; //Field offset: 0x30
	private bool containsFiles; //Field offset: 0x38

	public Byte[] data
	{
		 get { } //Length: 4144
	}

	internal static Encoding DefaultEncoding
	{
		internal get { } //Length: 9
	}

	public Dictionary<String, String> headers
	{
		 get { } //Length: 221
	}

	public WWWForm() { }

	public void AddField(string fieldName, string value) { }

	public void AddField(string fieldName, string value, Encoding e) { }

	public void AddField(string fieldName, int i) { }

	public Byte[] get_data() { }

	internal static Encoding get_DefaultEncoding() { }

	public Dictionary<String, String> get_headers() { }

}

