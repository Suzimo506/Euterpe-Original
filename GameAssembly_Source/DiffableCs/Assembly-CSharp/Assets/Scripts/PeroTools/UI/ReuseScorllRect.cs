namespace Assets.Scripts.PeroTools.UI;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ReuseScorllRect : MonoBehaviour
{
	internal enum ScrollType
	{
		Horizontal = 0,
		Vertical = 1,
	}

	public ScrollType scrollbarType; //Field offset: 0x18
	public Scrollbar scrollbar; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Slider slider; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject cell; //Field offset: 0x30
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int maxCount; //Field offset: 0x38
	private int m_ContentCount; //Field offset: 0x3C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int seeCount; //Field offset: 0x40
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int startAt; //Field offset: 0x44
	public bool isInitAtStart; //Field offset: 0x48
	public string positiveButtonName; //Field offset: 0x50
	public string negativeButtonName; //Field offset: 0x58
	public RectTransform content; //Field offset: 0x60
	private int m_FirstCellIndex; //Field offset: 0x68
	protected bool isHideSlider; //Field offset: 0x6C
	private bool m_IsHasListener; //Field offset: 0x6D
	private bool m_AfterAddListener; //Field offset: 0x6E

	public ReuseScorllRect() { }

	private void Awake() { }

	public void InitList() { }

	public override void OnUpdate() { }

	private void RefreshFrom(int start) { }

	private void RefreshScorllBar(float f) { }

	public void ScrollToNext() { }

	public void ScrollToPrevious() { }

	public override void SetCell(GameObject obj, int index) { }

	public void SetContentCount(int i) { }

	public void SetScorllbarListenerEnable(bool enable) { }

	private void Update() { }

}

