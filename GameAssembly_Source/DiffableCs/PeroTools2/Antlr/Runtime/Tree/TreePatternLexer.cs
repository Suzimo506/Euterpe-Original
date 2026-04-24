namespace Antlr.Runtime.Tree;

public class TreePatternLexer
{
	public const int Begin = 1; //Field offset: 0x0
	public const int End = 2; //Field offset: 0x0
	public const int Id = 3; //Field offset: 0x0
	public const int Arg = 4; //Field offset: 0x0
	public const int Percent = 5; //Field offset: 0x0
	public const int Colon = 6; //Field offset: 0x0
	public const int Dot = 7; //Field offset: 0x0
	protected string pattern; //Field offset: 0x10
	protected int p; //Field offset: 0x18
	protected int c; //Field offset: 0x1C
	protected int n; //Field offset: 0x20
	public StringBuilder sval; //Field offset: 0x28
	public bool error; //Field offset: 0x30

	public TreePatternLexer(string pattern) { }

	protected override void Consume() { }

	public override int NextToken() { }

}

