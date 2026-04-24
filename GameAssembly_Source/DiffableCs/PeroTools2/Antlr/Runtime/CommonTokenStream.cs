namespace Antlr.Runtime;

public class CommonTokenStream : BufferedTokenStream
{
	private int _channel; //Field offset: 0x30

	public int Channel
	{
		 get { } //Length: 4
	}

	public virtual ITokenSource TokenSource
	{
		 get { } //Length: 5
		 set { } //Length: 109
	}

	public CommonTokenStream() { }

	public CommonTokenStream(ITokenSource tokenSource) { }

	public CommonTokenStream(ITokenSource tokenSource, int channel) { }

	public virtual void Consume() { }

	public int get_Channel() { }

	public virtual ITokenSource get_TokenSource() { }

	protected virtual IToken LB(int k) { }

	public virtual IToken LT(int k) { }

	public virtual void set_TokenSource(ITokenSource value) { }

	protected virtual void Setup() { }

	protected override int SkipOffTokenChannels(int i) { }

	protected override int SkipOffTokenChannelsReverse(int i) { }

}

