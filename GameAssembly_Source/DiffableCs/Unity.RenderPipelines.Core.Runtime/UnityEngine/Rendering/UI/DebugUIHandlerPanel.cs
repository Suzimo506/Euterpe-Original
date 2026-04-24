namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerPanel : MonoBehaviour
{
	public Text nameLabel; //Field offset: 0x18
	public ScrollRect scrollRect; //Field offset: 0x20
	public RectTransform viewport; //Field offset: 0x28
	private RectTransform m_ScrollTransform; //Field offset: 0x30
	private RectTransform m_ContentTransform; //Field offset: 0x38
	private RectTransform m_MaskTransform; //Field offset: 0x40
	protected private Panel m_Panel; //Field offset: 0x48

	public DebugUIHandlerPanel() { }

	internal DebugUIHandlerWidget GetFirstItem() { }

	internal Panel GetPanel() { }

	private float GetYPosInScroll(RectTransform target) { }

	private void OnEnable() { }

	internal void ScrollTo(DebugUIHandlerWidget target) { }

	internal void SetPanel(Panel panel) { }

}

