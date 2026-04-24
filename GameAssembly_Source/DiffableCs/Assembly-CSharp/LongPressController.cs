//Type is in global namespace

public class LongPressController : BaseEnemyObjectController
{
	public static int psidx; //Field offset: 0x0
	private bool m_IsActive; //Field offset: 0x1F0
	private bool m_IsHurt; //Field offset: 0x1F1
	private int m_FingerId; //Field offset: 0x1F4
	private MusicData m_PMusicData; //Field offset: 0x1F8
	private List<LongPressController> m_LongChild; //Field offset: 0x350

	public MusicData PMusicData
	{
		 get { } //Length: 164
	}

	public SpineActionController PSpineActionController
	{
		 get { } //Length: 117
	}

	private static LongPressController() { }

	public LongPressController() { }

	[CompilerGenerated]
	private bool <Init>b__11_0(MusicData m) { }

	private void AddChild(LongPressController LongPressCtrl) { }

	public virtual bool ControllerMissCheck(int i, decimal currentTick) { }

	public MusicData get_PMusicData() { }

	public SpineActionController get_PSpineActionController() { }

	public static int GetPMusicIndex(int pressIdx) { }

	public virtual void Init(int scene) { }

	private void LongPressEnd() { }

	public void LongPressHurt() { }

	public void OnControllerHit(TimeNodeOrder tno, TimeNodeOrder[] tnos, int count) { }

	public virtual bool OnControllerMiss(int i) { }

	public void SetChildActive(bool active) { }

	public void SetChildFingerId(int fingerId) { }

	private void SetChildHurt(bool hurt) { }

	public virtual void SetVisible(bool enable) { }

	public void TouchEndResult(TimeNodeOrder tno) { }

}

