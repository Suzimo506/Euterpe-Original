namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class UIPointer : UIBehaviour
{
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _hideHardwarePointer; //Field offset: 0x18
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _autoSort; //Field offset: 0x19
	private RectTransform _canvasRectTransform; //Field offset: 0x20

	public bool autoSort
	{
		 get { } //Length: 5
		 set { } //Length: 52
	}

	public UIPointer() { }

	protected virtual void Awake() { }

	public bool get_autoSort() { }

	private void GetDependencies() { }

	protected virtual void OnCanvasGroupChanged() { }

	public void OnScreenPositionChanged(Vector2 screenPosition) { }

	protected virtual void OnTransformParentChanged() { }

	public void set_autoSort(bool value) { }

	private void Update() { }

}

