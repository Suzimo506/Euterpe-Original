namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DualShock4SpecialFeaturesExample : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public int touchId; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <HandleTouchpad>b__0(Touch x) { }

	}

	private class Touch
	{
		public GameObject go; //Field offset: 0x10
		public int touchId; //Field offset: 0x18

		public Touch() { }

	}

	private const int maxTouches = 2; //Field offset: 0x0
	public int playerId; //Field offset: 0x18
	public Transform touchpadTransform; //Field offset: 0x20
	public GameObject lightObject; //Field offset: 0x28
	public Transform accelerometerTransform; //Field offset: 0x30
	private List<Touch> touches; //Field offset: 0x38
	private Queue<Touch> unusedTouches; //Field offset: 0x40
	private bool isFlashing; //Field offset: 0x48
	private GUIStyle textStyle; //Field offset: 0x50

	private Player player
	{
		private get { } //Length: 102
	}

	public DualShock4SpecialFeaturesExample() { }

	private void Awake() { }

	private Player get_player() { }

	private IDualShock4Extension GetFirstDS4(Player player) { }

	private void HandleTouchpad(IDualShock4Extension ds4) { }

	private void InitializeTouchObjects() { }

	private void OnGUI() { }

	private void ResetOrientation() { }

	private void SetRandomLightColor() { }

	private void StartLightFlash() { }

	private void StopLightFlash() { }

	private void Update() { }

}

