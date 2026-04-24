namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerBitField : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x58
	public UIFoldout valueToggle; //Field offset: 0x60
	public List<DebugUIHandlerIndirectToggle> toggles; //Field offset: 0x68
	private BitField m_Field; //Field offset: 0x70
	private DebugUIHandlerContainer m_Container; //Field offset: 0x78

	public DebugUIHandlerBitField() { }

	private bool GetValue(int index) { }

	public virtual DebugUIHandlerWidget Next() { }

	public virtual void OnAction() { }

	public virtual void OnDecrement(bool fast) { }

	public virtual void OnDeselection() { }

	public virtual void OnIncrement(bool fast) { }

	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	private void SetValue(int index, bool value) { }

	internal virtual void SetWidget(Widget widget) { }

}

