namespace MS.Internal.Xml.XPath;

internal class CompiledXpathExpr : XPathExpression
{
	private class UndefinedXsltContext : XsltContext
	{
		private IXmlNamespaceResolver nsResolver; //Field offset: 0x50

		public virtual string DefaultNamespace
		{
			 get { } //Length: 53
		}

		public virtual bool Whitespace
		{
			 get { } //Length: 3
		}

		public UndefinedXsltContext(IXmlNamespaceResolver nsResolver) { }

		public virtual string get_DefaultNamespace() { }

		public virtual bool get_Whitespace() { }

		public virtual string LookupNamespace(string prefix) { }

		public virtual bool PreserveWhitespace(XPathNavigator node) { }

		public virtual IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

		public virtual IXsltContextVariable ResolveVariable(string prefix, string name) { }

	}

	private Query query; //Field offset: 0x10
	private string expr; //Field offset: 0x18
	private bool needContext; //Field offset: 0x20

	internal Query QueryTree
	{
		internal get { } //Length: 81
	}

	internal CompiledXpathExpr(Query query, string expression, bool needContext) { }

	internal Query get_QueryTree() { }

	public virtual void SetContext(IXmlNamespaceResolver nsResolver) { }

}

