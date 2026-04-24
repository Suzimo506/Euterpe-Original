namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class UIImageHelper : MonoBehaviour
{
	private class State
	{
		[SerializeField]
		public Color color; //Field offset: 0x10

		public State() { }

		public void Set(Image image) { }

	}

	[SerializeField]
	private State enabledState; //Field offset: 0x18
	[SerializeField]
	private State disabledState; //Field offset: 0x20
	private bool currentState; //Field offset: 0x28

	public UIImageHelper() { }

	public void Refresh() { }

	public void SetDisabledStateColor(Color color) { }

	public void SetEnabledState(bool newState) { }

	public void SetEnabledStateColor(Color color) { }

}

