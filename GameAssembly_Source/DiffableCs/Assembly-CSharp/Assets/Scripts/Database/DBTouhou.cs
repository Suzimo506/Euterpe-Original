namespace Assets.Scripts.Database;

public class DBTouhou : BaseDatabase
{
	[CompilerGenerated]
	private bool <isTouhouEasterEgg>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <isBadApple>k__BackingField; //Field offset: 0x11
	private int m_TouhouAvailableFeverCount; //Field offset: 0x14
	[CompilerGenerated]
	private List<Int32> <touhouBoomList>k__BackingField; //Field offset: 0x18

	public private bool isBadApple
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool isTouhouEasterEgg
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int touhouAvailableFeverCount
	{
		 get { } //Length: 4
		 set { } //Length: 257
	}

	public private List<Int32> touhouBoomList
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public DBTouhou() { }

	public virtual void AwakeInit() { }

	[CompilerGenerated]
	public bool get_isBadApple() { }

	[CompilerGenerated]
	public bool get_isTouhouEasterEgg() { }

	public int get_touhouAvailableFeverCount() { }

	[CompilerGenerated]
	public List<Int32> get_touhouBoomList() { }

	public virtual void Release() { }

	[CompilerGenerated]
	private void set_isBadApple(bool value) { }

	[CompilerGenerated]
	private void set_isTouhouEasterEgg(bool value) { }

	public void set_touhouAvailableFeverCount(int value) { }

	[CompilerGenerated]
	private void set_touhouBoomList(List<Int32> value) { }

}

