namespace Assets.Scripts.Database;

public class DBGameScene : BaseDatabase
{
	[CompilerGenerated]
	private bool <noteFreeze>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <bgFreeze>k__BackingField; //Field offset: 0x11

	public bool bgFreeze
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool noteFreeze
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DBGameScene() { }

	public virtual void AwakeInit() { }

	[CompilerGenerated]
	public bool get_bgFreeze() { }

	[CompilerGenerated]
	public bool get_noteFreeze() { }

	public virtual void Release() { }

	[CompilerGenerated]
	public void set_bgFreeze(bool value) { }

	[CompilerGenerated]
	public void set_noteFreeze(bool value) { }

}

