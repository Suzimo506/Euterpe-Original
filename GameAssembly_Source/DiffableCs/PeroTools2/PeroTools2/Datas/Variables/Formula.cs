namespace PeroTools2.Datas.Variables;

public class Formula : IVariable
{
	private static MemberInfo s_SetDataMethodInfo; //Field offset: 0x0
	[SerializeField]
	private string m_Expression; //Field offset: 0x10
	[SerializeField]
	private readonly List<IVariable> m_Params; //Field offset: 0x18
	private IValue m_Value; //Field offset: 0x20
	private Expression m_NcalExpression; //Field offset: 0x28
	private readonly DataObject m_DataObject; //Field offset: 0x30

	public override event Action<IVariable> onVariableChanged
	{
		 add { } //Length: 361
		 remove { } //Length: 362
	}

	public Formula() { }

	public override void add_onVariableChanged(Action<IVariable> value) { }

	private object GetResult() { }

	public override T GetValue() { }

	private void ListFunction(string name, FunctionArgs args) { }

	private void OtherFunction(string name, FunctionArgs args) { }

	public override void remove_onVariableChanged(Action<IVariable> value) { }

	public static void SetFormulaData(object variable, DataObject dataObject) { }

}

