namespace Assets.Scripts.PeroTools.Nice.Components;

public class ToggleGameObjectActivation : SerializedMonoBehaviour
{
	[SerializeField]
	private GameObject m_Object; //Field offset: 0x58
	[HideInInspector]
	[SerializeField]
	private Toggle m_Toggle; //Field offset: 0x60

	public ToggleGameObjectActivation() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnValueChanged(bool isOn) { }

}

