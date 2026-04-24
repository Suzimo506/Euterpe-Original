namespace Antlr.Runtime.Tree;

public class TreeWizard
{
	private class ActionVisitor : Visitor
	{
		private Action<Object> _action; //Field offset: 0x10

		public ActionVisitor(Action<Object> action) { }

		public virtual void Visit(object t) { }

	}

	private class FindTreeWizardContextVisitor : IContextVisitor
	{
		private TreeWizard _outer; //Field offset: 0x10
		private TreePattern _tpattern; //Field offset: 0x18
		private IList _subtrees; //Field offset: 0x20

		public FindTreeWizardContextVisitor(TreeWizard outer, TreePattern tpattern, IList subtrees) { }

		public override void Visit(object t, object parent, int childIndex, IDictionary<String, Object> labels) { }

	}

	private class FindTreeWizardVisitor : Visitor
	{
		private IList _nodes; //Field offset: 0x10

		public FindTreeWizardVisitor(IList nodes) { }

		public virtual void Visit(object t) { }

	}

	internal interface IContextVisitor
	{

		public void Visit(object t, object parent, int childIndex, IDictionary<String, Object> labels) { }

	}

	internal class TreePattern : CommonTree
	{
		public string label; //Field offset: 0x40
		public bool hasTextArg; //Field offset: 0x48

		public TreePattern(IToken payload) { }

		public virtual string ToString() { }

	}

	internal class TreePatternTreeAdaptor : CommonTreeAdaptor
	{

		public TreePatternTreeAdaptor() { }

		public virtual object Create(IToken payload) { }

	}

	internal abstract class Visitor : IContextVisitor
	{

		protected Visitor() { }

		public abstract void Visit(object t) { }

		public override void Visit(object t, object parent, int childIndex, IDictionary<String, Object> labels) { }

	}

	private class VisitTreeWizardContextVisitor : IContextVisitor
	{
		private TreeWizard _outer; //Field offset: 0x10
		private IContextVisitor _visitor; //Field offset: 0x18
		private IDictionary<String, Object> _labels; //Field offset: 0x20
		private TreePattern _tpattern; //Field offset: 0x28

		public VisitTreeWizardContextVisitor(TreeWizard outer, IContextVisitor visitor, IDictionary<String, Object> labels, TreePattern tpattern) { }

		public override void Visit(object t, object parent, int childIndex, IDictionary<String, Object> unusedlabels) { }

	}

	internal class WildcardTreePattern : TreePattern
	{

		public WildcardTreePattern(IToken payload) { }

	}

	protected ITreeAdaptor adaptor; //Field offset: 0x10
	protected IDictionary<String, Int32> tokenNameToTypeMap; //Field offset: 0x18

	public TreeWizard(ITreeAdaptor adaptor) { }

	public TreeWizard(ITreeAdaptor adaptor, IDictionary<String, Int32> tokenNameToTypeMap) { }

	public TreeWizard(ITreeAdaptor adaptor, String[] tokenNames) { }

	public TreeWizard(String[] tokenNames) { }

	public override IDictionary<String, Int32> ComputeTokenTypes(String[] tokenNames) { }

	public override object Create(string pattern) { }

	public static bool Equals(object t1, object t2, ITreeAdaptor adaptor) { }

	public bool Equals(object t1, object t2) { }

	protected static bool EqualsCore(object t1, object t2, ITreeAdaptor adaptor) { }

	public override IList Find(object t, string pattern) { }

	public override IList Find(object t, int ttype) { }

	public override object FindFirst(object t, int ttype) { }

	public override object FindFirst(object t, string pattern) { }

	public override int GetTokenType(string tokenName) { }

	public IDictionary<Int32, IList> Index(object t) { }

	protected override void IndexCore(object t, IDictionary<Int32, IList> m) { }

	public bool Parse(object t, string pattern, IDictionary<String, Object> labels) { }

	public bool Parse(object t, string pattern) { }

	protected override bool ParseCore(object t1, TreePattern tpattern, IDictionary<String, Object> labels) { }

	public void Visit(object t, int ttype, IContextVisitor visitor) { }

	public void Visit(object t, int ttype, Action<Object> action) { }

	public void Visit(object t, string pattern, IContextVisitor visitor) { }

	protected override void VisitCore(object t, object parent, int childIndex, int ttype, IContextVisitor visitor) { }

}

