namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x58
	public Toggle valueToggle; //Field offset: 0x60
	public Image checkmarkImage; //Field offset: 0x68
	public Func<Int32, Boolean> getter; //Field offset: 0x70
	public Action<Int32, Boolean> setter; //Field offset: 0x78
	internal int index; //Field offset: 0x80

	public DebugUIHandlerIndirectToggle() { }

	public void Init() { }

	public virtual void OnAction() { }

	public virtual void OnDeselection() { }

	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	internal void UpdateValueLabel() { }

}

