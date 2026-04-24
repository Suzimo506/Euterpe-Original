//Type is in global namespace

public class PointsBar : MonoBehaviour
{
	public FancyScrollView fancyScrollView; //Field offset: 0x18
	private List<Animator> m_BarAnim; //Field offset: 0x20
	private int m_AnimHash; //Field offset: 0x28
	private int m_CurrentPoint; //Field offset: 0x2C

	public PointsBar() { }

	private void Awake() { }

	private float CheckDis(float dis) { }

	private void FsvIntemIndexChange(int index) { }

	private void FsvOnOnUpdatePosition(float pos) { }

	private int LoopCell(int index) { }

	private void PlayAnim(int index, float pos) { }

	public void SetCurrentPoint(bool enable) { }

	public void SetDefaultPoint(int index) { }

}

