namespace System.Text.RegularExpressions;

internal class CaptureEnumerator : IEnumerator
{
	internal CaptureCollection _rcc; //Field offset: 0x10
	internal int _curindex; //Field offset: 0x18

	public Capture Capture
	{
		 get { } //Length: 146
	}

	public override object Current
	{
		 get { } //Length: 146
	}

	internal CaptureEnumerator(CaptureCollection rcc) { }

	public Capture get_Capture() { }

	public override object get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

}

