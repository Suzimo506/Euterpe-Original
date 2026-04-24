namespace Assets.Scripts.PeroTools.Nice.Actions;

public class ToggleGameObjectActivation : Action
{
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_GameObject; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private Toggle m_Toggle; //Field offset: 0x18

	public ToggleGameObjectActivation() { }

	public virtual void Enter() { }

	public virtual void Exit() { }

	private void OnValueChanged(bool isOn) { }

}

