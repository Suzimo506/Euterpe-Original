namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetFunction : Action
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IVariable, Object> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal object <Execute>b__4_0(IVariable p) { }

	}

	[SerializeField]
	private MethodType m_Type; //Field offset: 0x10
	[SerializeField]
	private Script m_Script; //Field offset: 0x18
	[SerializeField]
	private string m_EnumKey; //Field offset: 0x20
	[SerializeField]
	private List<IVariable> m_Params; //Field offset: 0x28

	public SetFunction() { }

	public virtual void Execute() { }

}

