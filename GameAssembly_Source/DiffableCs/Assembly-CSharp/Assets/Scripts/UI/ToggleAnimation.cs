namespace Assets.Scripts.UI;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ToggleAnimation : MonoBehaviour
{
	private Toggle m_Toggle; //Field offset: 0x18
	private Animator m_Animator; //Field offset: 0x20
	private int m_HashOn; //Field offset: 0x28
	private int m_HashOff; //Field offset: 0x2C
	private Nullable<Boolean> m_PrevState; //Field offset: 0x30
	public bool dontForceRefresh; //Field offset: 0x32

	public ToggleAnimation() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnValueChange(bool state) { }

}

