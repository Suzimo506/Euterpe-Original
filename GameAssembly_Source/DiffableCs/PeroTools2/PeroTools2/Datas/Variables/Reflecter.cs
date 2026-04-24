namespace PeroTools2.Datas.Variables;

public class Reflecter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IVariable, Object> <>9__4_0; //Field offset: 0x8
		public static Func<IVariable, IValue> <>9__4_1; //Field offset: 0x10
		public static Func<MemberInfo, Boolean> <>9__4_2; //Field offset: 0x18
		public static Func<MemberInfo, Boolean> <>9__5_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal object <GetValue>b__4_0(IVariable p) { }

		internal IValue <GetValue>b__4_1(IVariable p) { }

		internal bool <GetValue>b__4_2(MemberInfo m) { }

		internal bool <SetValue>b__5_0(MemberInfo m) { }

	}

	[SerializeField]
	private string m_Path; //Field offset: 0x10
	[SerializeField]
	private IVariable[] m_Params; //Field offset: 0x18
	[SerializeField]
	private Type m_Type; //Field offset: 0x20
	[SerializeField]
	private Delegate m_Delegate; //Field offset: 0x28

	public Reflecter() { }

	public IVariable[] GetParams() { }

	private object GetSource(object source) { }

	public object GetValue(object source) { }

	public void SetValue(object value, object source) { }

}

