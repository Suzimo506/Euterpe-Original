namespace PeroPeroGames;

public struct PeroCharEnumerator : ICloneable, IEnumerator<Char>, IEnumerator, IDisposable
{
	private PeroString str; //Field offset: 0x0
	private int index; //Field offset: 0x8
	private char currentElement; //Field offset: 0xC

	public override char Current
	{
		 get { } //Length: 113
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 135
	}

	internal PeroCharEnumerator(PeroString str) { }

	public override object Clone() { }

	public override void Dispose() { }

	public override char get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

