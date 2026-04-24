namespace System.Xml;

internal class ReaderPositionInfo : PositionInfo
{
	private IXmlLineInfo lineInfo; //Field offset: 0x10

	public virtual int LineNumber
	{
		 get { } //Length: 72
	}

	public virtual int LinePosition
	{
		 get { } //Length: 72
	}

	public ReaderPositionInfo(IXmlLineInfo lineInfo) { }

	public virtual int get_LineNumber() { }

	public virtual int get_LinePosition() { }

	public virtual bool HasLineInfo() { }

}

