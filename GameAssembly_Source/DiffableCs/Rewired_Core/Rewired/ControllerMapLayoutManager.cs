namespace Rewired;

public sealed class ControllerMapLayoutManager
{
	public class fVXGpyCTCiyuJlPQfkuntdxiioPLA
	{
		public bool nHVduHyOGbTpwQwakMqXUmFYSwHv; //Field offset: 0x10
		public bool OvtmZtJLbohHrGAaYudeHKxtHrQL; //Field offset: 0x11
		public ytJCOVIdYroWTnzXkEaZAxeiQGab[] rBXAPVdhISIHeplCNJgGlYnOYOmD; //Field offset: 0x18

		public fVXGpyCTCiyuJlPQfkuntdxiioPLA(bool unnamed_param_0, bool unnamed_param_1, ytJCOVIdYroWTnzXkEaZAxeiQGab[] unnamed_param_2) { }

	}

	[CustomClassObfuscation]
	[Preserve]
	internal sealed class Rule : IDeepCloneable
	{
		[Serialize]
		[SerializeField]
		private string _tag; //Field offset: 0x10
		[Serialize]
		[SerializeField]
		private Int32[] _categoryIds; //Field offset: 0x18
		[Serialize]
		[SerializeField]
		private int _layoutId; //Field offset: 0x20
		[Serialize]
		[SerializeField]
		private ControllerSetSelector _controllerSetSelector; //Field offset: 0x28
		private String[] _preInitCategoryNames; //Field offset: 0x30
		private string _preInitLayoutName; //Field offset: 0x38

		public int categoryId
		{
			 get { } //Length: 94
			 set { } //Length: 202
		}

		public Int32[] categoryIds
		{
			 get { } //Length: 106
			 set { } //Length: 106
		}

		public string categoryName
		{
			 get { } //Length: 370
			 set { } //Length: 634
		}

		public String[] categoryNames
		{
			 get { } //Length: 508
			 set { } //Length: 621
		}

		public ControllerSetSelector controllerSetSelector
		{
			 get { } //Length: 119
			 set { } //Length: 381
		}

		internal bool isValid
		{
			internal get { } //Length: 453
		}

		public int layoutId
		{
			 get { } //Length: 25
			 set { } //Length: 34
		}

		public string layoutName
		{
			 get { } //Length: 306
			 set { } //Length: 550
		}

		public string tag
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public Rule() { }

		public Rule(Rule unnamed_param_0) { }

		internal Rule(string unnamed_param_0, Int32[] unnamed_param_1, int unnamed_param_2, ControllerSetSelector unnamed_param_3) { }

		public int get_categoryId() { }

		public Int32[] get_categoryIds() { }

		public string get_categoryName() { }

		public String[] get_categoryNames() { }

		public ControllerSetSelector get_controllerSetSelector() { }

		internal bool get_isValid() { }

		public int get_layoutId() { }

		public string get_layoutName() { }

		public string get_tag() { }

		private void Initialize() { }

		private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

		public void set_categoryId(int value) { }

		public void set_categoryIds(Int32[] value) { }

		public void set_categoryName(string value) { }

		public void set_categoryNames(String[] value) { }

		public void set_controllerSetSelector(ControllerSetSelector value) { }

		public void set_layoutId(int value) { }

		public void set_layoutName(string value) { }

		public void set_tag(string value) { }

	}

	[CustomClassObfuscation]
	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Preserve]
	[SerializationType(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class RuleSet : IList<Rule>, ICollection<Rule>, IEnumerable<Rule>, IEnumerable, IDeepCloneable
	{
		private const string className = "ControllerMapLayoutManager.RuleSet"; //Field offset: 0x0
		[Serialize]
		[SerializeField]
		private bool _enabled; //Field offset: 0x10
		[Serialize]
		[SerializeField]
		private string _tag; //Field offset: 0x18
		[Serialize]
		[SerializeField]
		private List<Rule> _rules; //Field offset: 0x20

		public override int Count
		{
			 get { } //Length: 158
		}

		public bool enabled
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public override Rule Item
		{
			 get { } //Length: 181
			 set { } //Length: 188
		}

		public List<Rule> rules
		{
			 get { } //Length: 5
			 set { } //Length: 114
		}

		private override bool System.Collections.Generic.ICollection<Rewired.ControllerMapLayoutManager.Rule>.IsReadOnly
		{
			private get { } //Length: 171
		}

		public string tag
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		internal RuleSet(bool unnamed_param_0, string unnamed_param_1, List<Rule> unnamed_param_2) { }

		public RuleSet() { }

		public RuleSet(RuleSet unnamed_param_0) { }

		public override void Add(Rule item) { }

		private void CheckList() { }

		public override void Clear() { }

		public override bool Contains(Rule item) { }

		public override void CopyTo(Rule[] array, int arrayIndex) { }

		public Rule Find(Predicate<Rule> predicate) { }

		public int FindIndex(Predicate<Rule> predicate) { }

		public Rule FindLast(Predicate<Rule> predicate) { }

		public int FindLastIndex(Predicate<Rule> predicate) { }

		public override int get_Count() { }

		public bool get_enabled() { }

		public override Rule get_Item(int index) { }

		public List<Rule> get_rules() { }

		public string get_tag() { }

		public override IEnumerator<Rule> GetEnumerator() { }

		public override int IndexOf(Rule item) { }

		public override void Insert(int index, Rule item) { }

		public override bool Remove(Rule item) { }

		public override void RemoveAt(int index) { }

		private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

		public void set_enabled(bool value) { }

		public override void set_Item(int index, Rule value) { }

		public void set_rules(List<Rule> value) { }

		public void set_tag(string value) { }

		private override bool System.Collections.Generic.ICollection<Rewired.ControllerMapLayoutManager.Rule>.get_IsReadOnly() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private bool dDPTnfkiUGCQQHgOhJldFBaHbwjJc; //Field offset: 0x10
	private bool jjHdJAgWKttWeBlcmfMJrgpenKun; //Field offset: 0x11
	private Player UyWzFcIOnCWFKXzguwcfkbhiMinI; //Field offset: 0x18
	private fVXGpyCTCiyuJlPQfkuntdxiioPLA GiZGrrKgvWPOhyjEUlfUFLdGrgoOA; //Field offset: 0x20
	private readonly int VetpcoloufDUIHFBDUgRuDriUEsF; //Field offset: 0x28
	private List<RuleSet> LCWzLZaIoKaSTjDvPmLZnrjDyWLJA; //Field offset: 0x30
	private Action VNzAPnhukOziyOJoQHGyFxdVrnKxA; //Field offset: 0x38

	internal event Action FUQFaQwNaYWtZkCAjQsoGkufuObr
	{
		internal add { } //Length: 118
		internal remove { } //Length: 118
	}

	public bool enabled
	{
		 get { } //Length: 5
		 set { } //Length: 15
	}

	public bool loadFromUserDataStore
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public List<RuleSet> ruleSets
	{
		 get { } //Length: 5
		 set { } //Length: 103
	}

	internal ControllerMapLayoutManager(Player unnamed_param_0, fVXGpyCTCiyuJlPQfkuntdxiioPLA unnamed_param_1) { }

	public void Apply() { }

	private SerializedObject AqisXDDvDCPKwOpTfFxwWvniiRXz() { }

	private bool bBPMtmGuSfSJmZxBxGjnMufsajeR(SerializedObject unnamed_param_0) { }

	private void bmzBChLAjRLnuHrVTfqsJUSufdCS(SerializedObject unnamed_param_0) { }

	internal void FYNzYDScWQHKYPuzcktXSeCUNiJo(Action unnamed_param_0) { }

	public bool get_enabled() { }

	public bool get_loadFromUserDataStore() { }

	public List<RuleSet> get_ruleSets() { }

	public bool ImportJson(string jsonString) { }

	public bool ImportXml(string xmlString) { }

	internal void lDuoONqrzPMUmuzWiBedjVUaPSBK(Action unnamed_param_0) { }

	public void LoadDefaults() { }

	public void set_enabled(bool value) { }

	public void set_loadFromUserDataStore(bool value) { }

	public void set_ruleSets(List<RuleSet> value) { }

	public string ToJsonString() { }

	public string ToXmlString() { }

}

