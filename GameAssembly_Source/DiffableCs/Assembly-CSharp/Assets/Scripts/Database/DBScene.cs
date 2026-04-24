namespace Assets.Scripts.Database;

public class DBScene : BaseDatabase
{
	private List<IPause> m_Pauses; //Field offset: 0x10
	private List<IRelease> m_Releases; //Field offset: 0x18
	private List<IUpdate> m_Updates; //Field offset: 0x20
	private List<IUpdate> m_FixedUpdates; //Field offset: 0x28
	private Looper m_UpdateLooper; //Field offset: 0x30
	private Looper m_FixedUpdateLooper; //Field offset: 0x38

	public List<IPause> Pauses
	{
		 get { } //Length: 5
	}

	public DBScene() { }

	public void AddPause(IPause pause) { }

	public void AddRelease(IRelease release) { }

	public void AddUpdate(IUpdate update) { }

	public virtual void AwakeInit() { }

	public List<IPause> get_Pauses() { }

	public void OnFixedUpdate(float tick) { }

	public void OnUpdate(float tick) { }

	public virtual void Release() { }

	public void RemovePause(IPause pause) { }

	public void RemoveUpdate(IUpdate update) { }

}

