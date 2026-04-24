namespace Assets.Scripts.PeroTools.Nice.Variables;

public class Formula : IVariable, IValue
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public object variable; //Field offset: 0x10
		public IData data; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <SetFormulaData>b__0(MemberInfo m) { }

	}

	private static MemberInfo m_SetDataMi; //Field offset: 0x0
	[SerializeField]
	private string m_Expression; //Field offset: 0x10
	[SerializeField]
	private List<IVariable> m_Params; //Field offset: 0x18
	private IData m_Data; //Field offset: 0x20
	private Expression m_NcalExpression; //Field offset: 0x28

	public override object result
	{
		 get { } //Length: 7
		 set { } //Length: 3
	}

	private static Formula() { }

	public Formula() { }

	private object Evaluate() { }

	private void FieldFunction(string name, FunctionArgs args) { }

	public override object get_result() { }

	private static Dictionary<String, IVariable> GetIDataFields(object obj) { }

	private void ListFunction(string name, FunctionArgs args) { }

	private void OtherFunction(string name, FunctionArgs args) { }

	public override void set_result(object value) { }

	public static void SetFormulaData(object variable, IData data) { }

}

