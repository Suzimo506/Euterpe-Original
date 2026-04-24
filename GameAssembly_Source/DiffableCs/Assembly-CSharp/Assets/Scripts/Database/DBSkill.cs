namespace Assets.Scripts.Database;

internal class DBSkill : BaseDatabase
{
	private bool m_NekoSkillInvalid; //Field offset: 0x10
	private bool m_NekoSkillInvoke; //Field offset: 0x11
	private bool m_IsAutoPlay; //Field offset: 0x12
	[CompilerGenerated]
	private bool <isTouhouRole>k__BackingField; //Field offset: 0x13
	[CompilerGenerated]
	private bool <isTouhouSkillValid>k__BackingField; //Field offset: 0x14

	internal bool isAutoPlay
	{
		internal get { } //Length: 5
	}

	internal bool isTouhouRole
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool isTouhouSkillValid
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool nekoSkillInvalid
	{
		internal get { } //Length: 5
	}

	internal bool nekoSkillInvoke
	{
		internal get { } //Length: 5
	}

	public DBSkill() { }

	public virtual void AwakeInit() { }

	internal bool get_isAutoPlay() { }

	[CompilerGenerated]
	internal bool get_isTouhouRole() { }

	[CompilerGenerated]
	internal bool get_isTouhouSkillValid() { }

	internal bool get_nekoSkillInvalid() { }

	internal bool get_nekoSkillInvoke() { }

	public virtual void Release() { }

	[CompilerGenerated]
	internal void set_isTouhouRole(bool value) { }

	[CompilerGenerated]
	internal void set_isTouhouSkillValid(bool value) { }

	internal void SetAutoPlay(bool enable) { }

	internal void SetNekoSkillInvalid(bool invalid) { }

	internal void SetNekoSkillInvoke(bool invoke) { }

}

