namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetSliderValue : Action
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public float value; //Field offset: 0x10
		public SetSliderValue <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Execute>b__0() { }

		internal void <Execute>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_1
	{
		public float v; //Field offset: 0x10
		public <>c__DisplayClass10_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass10_1() { }

		internal void <Execute>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_2
	{
		public float v; //Field offset: 0x10
		public <>c__DisplayClass10_0 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass10_2() { }

		internal void <Execute>b__4() { }

	}

	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Object; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Percent; //Field offset: 0x18
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Duration; //Field offset: 0x20
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Curve; //Field offset: 0x28
	private Tweener m_Tweener; //Field offset: 0x30
	private Sequence m_Sequence; //Field offset: 0x38
	private Slider m_Slider; //Field offset: 0x40
	private Image m_Image; //Field offset: 0x48

	public virtual float duration
	{
		 get { } //Length: 94
	}

	public SetSliderValue() { }

	[CompilerGenerated]
	private void <Execute>b__10_2() { }

	[CompilerGenerated]
	private void <Execute>b__10_5() { }

	public virtual void Execute() { }

	public virtual void Exit() { }

	public virtual float get_duration() { }

	public virtual void Pause() { }

	public virtual void Resume() { }

}

