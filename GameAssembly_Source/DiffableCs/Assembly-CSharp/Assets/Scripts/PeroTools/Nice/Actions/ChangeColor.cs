namespace Assets.Scripts.PeroTools.Nice.Actions;

public class ChangeColor : Action
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string propertyName; //Field offset: 0x10
		public ChangeColor <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal Color <Execute>b__2() { }

		internal void <Execute>b__3(Color value) { }

	}

	[SerializeField]
	private string m_Path; //Field offset: 0x10
	[SerializeField]
	private Color m_Color; //Field offset: 0x18
	[SerializeField]
	private float m_Duration; //Field offset: 0x28
	[SerializeField]
	private Ease m_Ease; //Field offset: 0x2C
	[HideInInspector]
	[SerializeField]
	private object m_SourceObject; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private Renderer m_Renderer; //Field offset: 0x38
	private Material m_Material; //Field offset: 0x40
	private MemberInfo m_SetMemberInfo; //Field offset: 0x48
	private MemberInfo m_GetMemberInfo; //Field offset: 0x50
	private Tween m_Tween; //Field offset: 0x58

	public virtual float duration
	{
		 get { } //Length: 6
	}

	public ChangeColor() { }

	[CompilerGenerated]
	private Color <Execute>b__13_0() { }

	[CompilerGenerated]
	private void <Execute>b__13_1(Color value) { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	public virtual float get_duration() { }

	public virtual void Pause() { }

	public virtual void Resume() { }

}

