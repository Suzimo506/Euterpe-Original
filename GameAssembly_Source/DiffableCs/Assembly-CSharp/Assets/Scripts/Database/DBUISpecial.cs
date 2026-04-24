namespace Assets.Scripts.Database;

public class DBUISpecial : BaseDatabase
{
	public bool isBarrageMode; //Field offset: 0x10
	private bool m_IsReview; //Field offset: 0x11
	private bool m_MasterNekoEgg; //Field offset: 0x12
	private bool m_RoleNekoEggIsOn; //Field offset: 0x13
	private int m_BattleSfxType; //Field offset: 0x14

	internal int battleSfxType
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal bool IsReview
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool masterNekoEgg
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool roleNekoEggIsOn
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	public DBUISpecial() { }

	public virtual void AwakeInit() { }

	public virtual void Flush() { }

	internal int get_battleSfxType() { }

	internal bool get_IsReview() { }

	internal bool get_masterNekoEgg() { }

	internal bool get_roleNekoEggIsOn() { }

	public void InitDatabase() { }

	public virtual void Release() { }

	internal void set_battleSfxType(int value) { }

	internal void set_IsReview(bool value) { }

	internal void set_masterNekoEgg(bool value) { }

	internal void set_roleNekoEggIsOn(bool value) { }

}

