namespace Assets.Scripts.PeroTools.Nice.Variables;

public class Reflecter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MemberInfo, Boolean> <>9__3_0; //Field offset: 0x8
		public static Func<MemberInfo, Boolean> <>9__4_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetValue>b__3_0(MemberInfo m) { }

		internal bool <SetValue>b__4_0(MemberInfo m) { }

	}

	[SerializeField]
	private string m_Path; //Field offset: 0x10
	[SerializeField]
	private IVariable[] m_Params; //Field offset: 0x18
	[SerializeField]
	private Type m_Type; //Field offset: 0x20

	public Reflecter() { }

	private object GetSource(object source) { }

	public object GetValue(object source) { }

	public void SetValue(object value, object source) { }

}

