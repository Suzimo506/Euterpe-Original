//Type is in global namespace

public abstract class BaseSpineObjectController : MonoBehaviour, IPause
{
	public int idx; //Field offset: 0x18
	protected int m_SceneIdx; //Field offset: 0x1C
	protected Renderer m_Renderer; //Field offset: 0x20
	protected SpriteRenderer m_CatchAir; //Field offset: 0x28
	protected SpriteRenderer m_CatchGround; //Field offset: 0x30
	protected SpineActionController m_Sac; //Field offset: 0x38
	protected bool m_IsVisible; //Field offset: 0x40
	[CompilerGenerated]
	private bool <isIn>k__BackingField; //Field offset: 0x41
	protected GameObject m_Blood; //Field offset: 0x48

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public bool isIn
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool isVisible
	{
		 get { } //Length: 5
	}

	protected BaseSpineObjectController() { }

	public abstract bool ControllerMissCheck(int idx, decimal currentTick) { }

	public override bool get_IsGlobal() { }

	[CompilerGenerated]
	public bool get_isIn() { }

	public bool get_isVisible() { }

	public int GetIdx() { }

	public abstract void Init(int scene) { }

	public abstract void OnControllerAttacked(int result, bool isDeaded) { }

	public abstract bool OnControllerMiss(int idx) { }

	public abstract void OnControllerStart() { }

	public abstract void Pause(bool pauseCorountine) { }

	public abstract void Resume() { }

	[CompilerGenerated]
	protected void set_isIn(bool value) { }

	public abstract void SetIdx(int idx) { }

	protected override void SetOrder(int order) { }

	public override void SetVisible(bool enable) { }

	public void SyncAnimatorTick(float tick) { }

}

