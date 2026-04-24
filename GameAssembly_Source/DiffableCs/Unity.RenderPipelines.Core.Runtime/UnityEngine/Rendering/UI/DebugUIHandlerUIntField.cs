namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerUIntField : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x58
	public Text valueLabel; //Field offset: 0x60
	private UIntField m_Field; //Field offset: 0x68

	public DebugUIHandlerUIntField() { }

	private void ChangeValue(bool fast, int multiplier) { }

	public virtual void OnDecrement(bool fast) { }

	public virtual void OnDeselection() { }

	public virtual void OnIncrement(bool fast) { }

	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	internal virtual void SetWidget(Widget widget) { }

	private void UpdateValueLabel() { }

}

