namespace PeroTools2.Inputs;

public class InputManager : SingletonScriptableObject<InputManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Char, Boolean> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FindInput>b__7_0(char i) { }

	}

	[SerializeField]
	private InputActionAsset m_ActionAsset; //Field offset: 0x58
	private List<RaycastResult> m_RaycastResults; //Field offset: 0x60
	private PointerEventData m_PointerEventData; //Field offset: 0x68
	private InputAction m_Point; //Field offset: 0x70

	public Vector2 screenPos
	{
		 get { } //Length: 67
	}

	public InputManager() { }

	public InputAction FindInput(string id) { }

	public Vector2 get_screenPos() { }

	private void Init() { }

	public bool IsPointerOverRect(Camera cam, RectTransform[] targets) { }

	public bool IsPointerOverUI() { }

}

