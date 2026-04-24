namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerValue : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x58
	public Text valueLabel; //Field offset: 0x60
	private Value m_Field; //Field offset: 0x68
	private float m_Timer; //Field offset: 0x70

	public DebugUIHandlerValue() { }

	public virtual void OnDeselection() { }

	protected virtual void OnEnable() { }

	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	internal virtual void SetWidget(Widget widget) { }

	private void Update() { }

}

