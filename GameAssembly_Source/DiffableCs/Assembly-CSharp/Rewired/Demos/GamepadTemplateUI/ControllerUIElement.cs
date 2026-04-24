namespace Rewired.Demos.GamepadTemplateUI;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ControllerUIElement : MonoBehaviour
{
	[SerializeField]
	private Color _highlightColor; //Field offset: 0x18
	[SerializeField]
	private ControllerUIEffect _positiveUIEffect; //Field offset: 0x28
	[SerializeField]
	private ControllerUIEffect _negativeUIEffect; //Field offset: 0x30
	[SerializeField]
	private Text _label; //Field offset: 0x38
	[SerializeField]
	private Text _positiveLabel; //Field offset: 0x40
	[SerializeField]
	private Text _negativeLabel; //Field offset: 0x48
	[SerializeField]
	private ControllerUIElement[] _childElements; //Field offset: 0x50
	private Image _image; //Field offset: 0x58
	private Color _color; //Field offset: 0x60
	private Color _origColor; //Field offset: 0x70
	private bool _isActive; //Field offset: 0x80
	private float _highlightAmount; //Field offset: 0x84

	private bool hasEffects
	{
		private get { } //Length: 161
	}

	public ControllerUIElement() { }

	public void Activate(float amount) { }

	private void Awake() { }

	public void ClearLabels() { }

	public void Deactivate() { }

	private bool get_hasEffects() { }

	private void RedrawImage() { }

	public void SetLabel(string text, AxisRange labelType) { }

}

