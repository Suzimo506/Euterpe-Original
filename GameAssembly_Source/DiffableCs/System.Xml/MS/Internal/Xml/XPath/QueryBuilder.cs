namespace MS.Internal.Xml.XPath;

internal sealed class QueryBuilder
{
	private enum Flags
	{
		None = 0,
		SmartDesc = 1,
		PosFilter = 2,
		Filter = 4,
	}

	private enum Props
	{
		None = 0,
		PosFilter = 1,
		HasPosition = 2,
		HasLast = 4,
		NonFlat = 8,
	}

	private string query; //Field offset: 0x10
	private bool allowVar; //Field offset: 0x18
	private bool allowKey; //Field offset: 0x19
	private bool allowCurrent; //Field offset: 0x1A
	private bool needContext; //Field offset: 0x1B
	private BaseAxisQuery firstInput; //Field offset: 0x20
	private int parseDepth; //Field offset: 0x28

	public QueryBuilder() { }

	private Query Build(AstNode root, string query) { }

	internal Query Build(string query, bool allowVar, bool allowKey) { }

	internal Query Build(string query, out bool needContext) { }

	private bool CanBeNumber(Query q) { }

	private List<Query> ProcessArguments(ArrayList args, out Props props) { }

	private Query ProcessAxis(Axis root, Flags flags, out Props props) { }

	private Query ProcessFilter(Filter root, Flags flags, out Props props) { }

	private Query ProcessFunction(Function root, out Props props) { }

	private Query ProcessNode(AstNode root, Flags flags, out Props props) { }

	private Query ProcessOperator(Operator root, out Props props) { }

	private Query ProcessVariable(Variable root) { }

	private void Reset() { }

}

