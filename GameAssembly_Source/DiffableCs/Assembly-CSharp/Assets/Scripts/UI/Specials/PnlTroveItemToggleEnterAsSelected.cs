namespace Assets.Scripts.UI.Specials;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PnlTroveItemToggleEnterAsSelected : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	private Toggle m_Toggle; //Field offset: 0x18

	public PnlTroveItemToggleEnterAsSelected() { }

	private void Awake() { }

	public override void OnSelect(BaseEventData eventData) { }

	private void OnToggleChange(bool state) { }

}

