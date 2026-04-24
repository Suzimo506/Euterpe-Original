namespace Antlr.Runtime.Tree;

public abstract class RewriteRuleElementStream
{
	protected int cursor; //Field offset: 0x10
	protected object singleElement; //Field offset: 0x18
	protected IList elements; //Field offset: 0x20
	protected bool dirty; //Field offset: 0x28
	protected string elementDescription; //Field offset: 0x30
	protected ITreeAdaptor adaptor; //Field offset: 0x38

	public override int Count
	{
		 get { } //Length: 82
	}

	public override string Description
	{
		 get { } //Length: 5
	}

	public override bool HasNext
	{
		 get { } //Length: 105
	}

	public RewriteRuleElementStream(ITreeAdaptor adaptor, string elementDescription) { }

	public RewriteRuleElementStream(ITreeAdaptor adaptor, string elementDescription, object oneElement) { }

	public RewriteRuleElementStream(ITreeAdaptor adaptor, string elementDescription, IList elements) { }

	public override void Add(object el) { }

	protected abstract object Dup(object el) { }

	public override int get_Count() { }

	public override string get_Description() { }

	public override bool get_HasNext() { }

	protected override object NextCore() { }

	public override object NextTree() { }

	public override void Reset() { }

	protected override object ToTree(object el) { }

}

