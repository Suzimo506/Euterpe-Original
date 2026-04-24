namespace MS.Internal.Xml.XPath;

internal sealed class LogicalExpr : ValueQuery
{
	private sealed class cmpXslt : MulticastDelegate
	{

		public cmpXslt(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Op op, object val1, object val2, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(Op op, object val1, object val2) { }

	}

	private struct NodeSet
	{
		private Query opnd; //Field offset: 0x0
		private XPathNavigator current; //Field offset: 0x8

		public string Value
		{
			 get { } //Length: 39
		}

		public NodeSet(object opnd) { }

		public string get_Value() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	private static readonly cmpXslt[][] CompXsltE; //Field offset: 0x0
	private static readonly cmpXslt[][] CompXsltO; //Field offset: 0x8
	private Op op; //Field offset: 0x18
	private Query opnd1; //Field offset: 0x20
	private Query opnd2; //Field offset: 0x28

	public virtual XPathResultType StaticType
	{
		 get { } //Length: 6
	}

	private static LogicalExpr() { }

	public LogicalExpr(Op op, Query opnd1, Query opnd2) { }

	private LogicalExpr(LogicalExpr other) { }

	public virtual XPathNodeIterator Clone() { }

	private static bool cmpBoolBoolE(Op op, object val1, object val2) { }

	private static bool cmpBoolBoolE(Op op, bool n1, bool n2) { }

	private static bool cmpBoolBoolO(Op op, object val1, object val2) { }

	private static bool cmpBoolNumberE(Op op, object val1, object val2) { }

	private static bool cmpBoolNumberO(Op op, object val1, object val2) { }

	private static bool cmpBoolStringE(Op op, object val1, object val2) { }

	private static bool cmpBoolStringO(Op op, object val1, object val2) { }

	private static bool cmpNumberNumber(Op op, object val1, object val2) { }

	private static bool cmpNumberNumber(Op op, double n1, double n2) { }

	private static bool cmpNumberNumberO(Op op, double n1, double n2) { }

	private static bool cmpQueryBoolE(Op op, object val1, object val2) { }

	private static bool cmpQueryBoolO(Op op, object val1, object val2) { }

	private static bool cmpQueryNumber(Op op, object val1, object val2) { }

	private static bool cmpQueryQueryE(Op op, object val1, object val2) { }

	private static bool cmpQueryQueryO(Op op, object val1, object val2) { }

	private static bool cmpQueryStringE(Op op, object val1, object val2) { }

	private static bool cmpQueryStringO(Op op, object val1, object val2) { }

	private static bool cmpRtfBoolE(Op op, object val1, object val2) { }

	private static bool cmpRtfBoolO(Op op, object val1, object val2) { }

	private static bool cmpRtfNumber(Op op, object val1, object val2) { }

	private static bool cmpRtfQueryE(Op op, object val1, object val2) { }

	private static bool cmpRtfQueryO(Op op, object val1, object val2) { }

	private static bool cmpRtfRtfE(Op op, object val1, object val2) { }

	private static bool cmpRtfRtfO(Op op, object val1, object val2) { }

	private static bool cmpRtfStringE(Op op, object val1, object val2) { }

	private static bool cmpRtfStringO(Op op, object val1, object val2) { }

	private static bool cmpStringNumber(Op op, object val1, object val2) { }

	private static bool cmpStringStringE(Op op, string n1, string n2) { }

	private static bool cmpStringStringE(Op op, object val1, object val2) { }

	private static bool cmpStringStringO(Op op, object val1, object val2) { }

	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	public virtual XPathResultType get_StaticType() { }

	private static string Rtf(object o) { }

	public virtual void SetXsltContext(XsltContext context) { }

}

