namespace Antlr.Runtime.Tree;

[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class BaseTree : ITree
{
	private IList<ITree> _children; //Field offset: 0x10
	[CompilerGenerated]
	private int <Line>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <CharPositionInLine>k__BackingField; //Field offset: 0x1C

	public override int CharPositionInLine
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override int ChildCount
	{
		 get { } //Length: 117
	}

	public override int ChildIndex
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public private override IList<ITree> Children
	{
		 get { } //Length: 5
		private set { } //Length: 12
	}

	public override bool IsNil
	{
		 get { } //Length: 3
	}

	public override int Line
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override ITree Parent
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public abstract string Text
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract int TokenStartIndex
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract int TokenStopIndex
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract int Type
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public BaseTree() { }

	public BaseTree(ITree node) { }

	public override void AddChild(ITree t) { }

	public override void AddChildren(IEnumerable<ITree> kids) { }

	protected override IList<ITree> CreateChildrenList() { }

	public override object DeleteChild(int i) { }

	public abstract ITree DupNode() { }

	public override void FreshenParentAndChildIndexes(int offset) { }

	public override void FreshenParentAndChildIndexes() { }

	[CompilerGenerated]
	public override int get_CharPositionInLine() { }

	public override int get_ChildCount() { }

	public override int get_ChildIndex() { }

	public override IList<ITree> get_Children() { }

	public override bool get_IsNil() { }

	[CompilerGenerated]
	public override int get_Line() { }

	public override ITree get_Parent() { }

	public abstract string get_Text() { }

	public abstract int get_TokenStartIndex() { }

	public abstract int get_TokenStopIndex() { }

	public abstract int get_Type() { }

	public override ITree GetAncestor(int ttype) { }

	public override IList<ITree> GetAncestors() { }

	public override ITree GetChild(int i) { }

	public override ITree GetFirstChildWithType(int type) { }

	public override bool HasAncestor(int ttype) { }

	public override void ReplaceChildren(int startChildIndex, int stopChildIndex, object t) { }

	public override void SanityCheckParentAndChildIndexes() { }

	public override void SanityCheckParentAndChildIndexes(ITree parent, int i) { }

	[CompilerGenerated]
	public override void set_CharPositionInLine(int value) { }

	public override void set_ChildIndex(int value) { }

	private void set_Children(IList<ITree> value) { }

	[CompilerGenerated]
	public override void set_Line(int value) { }

	public override void set_Parent(ITree value) { }

	public abstract void set_Text(string value) { }

	public abstract void set_TokenStartIndex(int value) { }

	public abstract void set_TokenStopIndex(int value) { }

	public abstract void set_Type(int value) { }

	public override void SetChild(int i, ITree t) { }

	public abstract string ToString() { }

	public override string ToStringTree() { }

}

