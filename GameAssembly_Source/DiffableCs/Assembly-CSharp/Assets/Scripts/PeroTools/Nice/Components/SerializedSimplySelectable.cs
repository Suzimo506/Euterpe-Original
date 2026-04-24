namespace Assets.Scripts.PeroTools.Nice.Components;

public class SerializedSimplySelectable : SerializedUIBehaviour
{
	public bool interactable; //Field offset: 0x58
	private bool m_GroupsAllowInteraction; //Field offset: 0x59
	private readonly List<CanvasGroup> m_CanvasGroupCache; //Field offset: 0x60

	public SerializedSimplySelectable() { }

	public override bool IsInteractable() { }

	protected virtual void OnCanvasGroupChanged() { }

}

