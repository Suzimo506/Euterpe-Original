namespace Rewired.Demos.GamepadTemplateUI;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ControllerUIEffect : MonoBehaviour
{
	[SerializeField]
	private Color _highlightColor; //Field offset: 0x18
	private Image _image; //Field offset: 0x28
	private Color _color; //Field offset: 0x30
	private Color _origColor; //Field offset: 0x40
	private bool _isActive; //Field offset: 0x50
	private float _highlightAmount; //Field offset: 0x54

	public ControllerUIEffect() { }

	public void Activate(float amount) { }

	private void Awake() { }

	public void Deactivate() { }

	private void RedrawImage() { }

}

