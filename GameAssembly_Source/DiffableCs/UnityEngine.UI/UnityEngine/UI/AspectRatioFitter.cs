namespace UnityEngine.UI;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	internal enum AspectMode
	{
		None = 0,
		WidthControlsHeight = 1,
		HeightControlsWidth = 2,
		FitInParent = 3,
		EnvelopeParent = 4,
	}

	[SerializeField]
	private AspectMode m_AspectMode; //Field offset: 0x18
	[SerializeField]
	private float m_AspectRatio; //Field offset: 0x1C
	private RectTransform m_Rect; //Field offset: 0x20
	private bool m_DelayedSetDirty; //Field offset: 0x28
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x29

	public AspectMode aspectMode
	{
		 get { } //Length: 4
		 set { } //Length: 85
	}

	public float aspectRatio
	{
		 get { } //Length: 6
		 set { } //Length: 88
	}

	private RectTransform rectTransform
	{
		private get { } //Length: 147
	}

	protected AspectRatioFitter() { }

	public AspectMode get_aspectMode() { }

	public float get_aspectRatio() { }

	private RectTransform get_rectTransform() { }

	private Vector2 GetParentSize() { }

	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	public void set_aspectMode(AspectMode value) { }

	public void set_aspectRatio(float value) { }

	protected void SetDirty() { }

	public override void SetLayoutHorizontal() { }

	public override void SetLayoutVertical() { }

	protected override void Update() { }

	private void UpdateRect() { }

}

