namespace System.Text;

public sealed class DecoderReplacementFallback : DecoderFallback
{
	private string strDefault; //Field offset: 0x18

	public string DefaultString
	{
		 get { } //Length: 5
	}

	public virtual int MaxCharCount
	{
		 get { } //Length: 26
	}

	public DecoderReplacementFallback() { }

	public DecoderReplacementFallback(string replacement) { }

	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	public virtual bool Equals(object value) { }

	public string get_DefaultString() { }

	public virtual int get_MaxCharCount() { }

	public virtual int GetHashCode() { }

}

