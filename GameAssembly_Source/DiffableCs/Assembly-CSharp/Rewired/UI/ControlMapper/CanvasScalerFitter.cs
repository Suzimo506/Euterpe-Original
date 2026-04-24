namespace Rewired.UI.ControlMapper;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CanvasScalerFitter : MonoBehaviour
{
	private class BreakPoint
	{
		[SerializeField]
		public string name; //Field offset: 0x10
		[SerializeField]
		public float screenAspectRatio; //Field offset: 0x18
		[SerializeField]
		public Vector2 referenceResolution; //Field offset: 0x1C

		public BreakPoint() { }

	}

	[SerializeField]
	private BreakPoint[] breakPoints; //Field offset: 0x18
	private CanvasScalerExt canvasScaler; //Field offset: 0x20
	private int screenWidth; //Field offset: 0x28
	private int screenHeight; //Field offset: 0x2C
	private Action ScreenSizeChanged; //Field offset: 0x30

	public CanvasScalerFitter() { }

	private void OnEnable() { }

	private void Update() { }

	private void UpdateSize() { }

}

