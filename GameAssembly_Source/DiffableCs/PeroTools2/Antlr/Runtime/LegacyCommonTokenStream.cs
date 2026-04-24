namespace Antlr.Runtime;

public class LegacyCommonTokenStream : ITokenStream, IIntStream
{
	private ITokenSource _tokenSource; //Field offset: 0x10
	protected List<IToken> tokens; //Field offset: 0x18
	protected IDictionary<Int32, Int32> channelOverrideMap; //Field offset: 0x20
	protected Dictionary<Int32, Int32> discardSet; //Field offset: 0x28
	protected int channel; //Field offset: 0x30
	protected bool discardOffChannelTokens; //Field offset: 0x34
	protected int lastMarker; //Field offset: 0x38
	protected int p; //Field offset: 0x3C
	[CompilerGenerated]
	private int <Range>k__BackingField; //Field offset: 0x40

	public override int Count
	{
		 get { } //Length: 59
	}

	public override int Index
	{
		 get { } //Length: 4
	}

	public override int Range
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override string SourceName
	{
		 get { } //Length: 90
	}

	public override ITokenSource TokenSource
	{
		 get { } //Length: 5
	}

	public LegacyCommonTokenStream() { }

	public LegacyCommonTokenStream(ITokenSource tokenSource) { }

	public LegacyCommonTokenStream(ITokenSource tokenSource, int channel) { }

	public override void Consume() { }

	public override void DiscardTokenType(int ttype) { }

	public override void FillBuffer() { }

	public override IToken Get(int i) { }

	public override int get_Count() { }

	public override int get_Index() { }

	[CompilerGenerated]
	public override int get_Range() { }

	public override string get_SourceName() { }

	public override ITokenSource get_TokenSource() { }

	public override IList<IToken> GetTokens(int start, int stop, int ttype) { }

	public override IList<IToken> GetTokens(int start, int stop, BitSet types) { }

	public override IList<IToken> GetTokens(int start, int stop) { }

	public override IList<IToken> GetTokens(int start, int stop, IList<Int32> types) { }

	public override IList<IToken> GetTokens() { }

	public override int LA(int i) { }

	protected override IToken LB(int k) { }

	public override IToken LT(int k) { }

	public override int Mark() { }

	public override void Release(int marker) { }

	public override void Reset() { }

	public override void Rewind(int marker) { }

	public override void Rewind() { }

	public override void Seek(int index) { }

	[CompilerGenerated]
	protected override void set_Range(int value) { }

	public override void SetDiscardOffChannelTokens(bool discardOffChannelTokens) { }

	public override void SetTokenSource(ITokenSource tokenSource) { }

	public override void SetTokenTypeChannel(int ttype, int channel) { }

	protected override int SkipOffTokenChannels(int i) { }

	protected override int SkipOffTokenChannelsReverse(int i) { }

	public override string ToString(int start, int stop) { }

	public virtual string ToString() { }

	public override string ToString(IToken start, IToken stop) { }

}

