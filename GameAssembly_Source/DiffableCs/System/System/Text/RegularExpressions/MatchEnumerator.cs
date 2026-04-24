namespace System.Text.RegularExpressions;

internal class MatchEnumerator : IEnumerator
{
	internal MatchCollection _matchcoll; //Field offset: 0x10
	internal Match _match; //Field offset: 0x18
	internal int _curindex; //Field offset: 0x20
	internal bool _done; //Field offset: 0x24

	public override object Current
	{
		 get { } //Length: 122
	}

	internal MatchEnumerator(MatchCollection matchcoll) { }

	public override object get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

}

