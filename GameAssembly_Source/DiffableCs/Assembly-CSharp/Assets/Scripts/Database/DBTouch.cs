namespace Assets.Scripts.Database;

public class DBTouch : BaseDatabase
{
	private List<CatchInput> m_CatchInputs; //Field offset: 0x10

	public DBTouch() { }

	public virtual void AwakeInit() { }

	public CatchInput GetCatchInput(int index) { }

	public int IsCatching(bool isGround, float time) { }

	public void JkRefreshCatchTime(int index, float time) { }

	public void JkSetCatchTime(int index, float time) { }

	public virtual void Release() { }

}

