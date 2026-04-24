namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerEnumField : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x58
	public Text valueLabel; //Field offset: 0x60
	protected private EnumField m_Field; //Field offset: 0x68

	public DebugUIHandlerEnumField() { }

	public virtual void OnAction() { }

	public virtual void OnDecrement(bool fast) { }

	public virtual void OnDeselection() { }

	public virtual void OnIncrement(bool fast) { }

	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	internal virtual void SetWidget(Widget widget) { }

	protected override void UpdateValueLabel() { }

}

