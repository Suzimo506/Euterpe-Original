namespace Assets.Scripts.UI;

public class PeroInputField : InputField
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__8_0(bool <p0>) { }

	}

	private bool m_PrevFocus; //Field offset: 0x210
	[CompilerGenerated]
	private Action<Boolean> onFocusChanged; //Field offset: 0x218

	public event Action<Boolean> onFocusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool prevFocus
	{
		 get { } //Length: 8
	}

	public PeroInputField() { }

	[CompilerGenerated]
	public void add_onFocusChanged(Action<Boolean> value) { }

	public void Deselect() { }

	public bool get_prevFocus() { }

	protected virtual void LateUpdate() { }

	[CompilerGenerated]
	public void remove_onFocusChanged(Action<Boolean> value) { }

}

