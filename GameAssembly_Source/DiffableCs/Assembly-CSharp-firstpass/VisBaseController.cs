//Type is in global namespace

public abstract class VisBaseController : MonoBehaviour, IVisManagerTarget
{
	internal static class Defaults
	{
		public static int controllerNameCounter; //Field offset: 0x64A50
		public const string controllerName = "Default"; //Field offset: 0x64A97
		public const float increaseRate = 1; //Field offset: 0x64AA0
		public const bool limitDecreaseRate = True; //Field offset: 0x64AFD
		public const bool limitIncreaseRate = False; //Field offset: 0x2C927BC
		public const float decreaseRate = 1; //Field offset: 0x2C927BC

		private static Defaults() { }

	}

	public const float mc_fTargetAdjustedDifferenceTime = 0.016666668; //Field offset: 0x0
	[SerializeField]
	private VisManager m_oVisManager; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private string m_szLastVisManagerName; //Field offset: 0x20
	public string controllerName; //Field offset: 0x28
	public bool limitIncreaseRate; //Field offset: 0x30
	public float increaseRate; //Field offset: 0x34
	public bool limitDecreaseRate; //Field offset: 0x38
	public float decreaseRate; //Field offset: 0x3C
	protected float m_fPreviousValue; //Field offset: 0x40
	protected float m_fValue; //Field offset: 0x44
	protected float m_fValueDifference; //Field offset: 0x48
	protected float m_fAdjustedValueDifference; //Field offset: 0x4C
	private float m_fMinValue; //Field offset: 0x50
	private float m_fMaxValue; //Field offset: 0x54

	public override string LastManagerName
	{
		 get { } //Length: 5
	}

	public override VisManager Manager
	{
		 get { } //Length: 5
		 set { } //Length: 336
	}

	public float MaxValue
	{
		 get { } //Length: 6
	}

	public float MinValue
	{
		 get { } //Length: 6
	}

	protected VisBaseController() { }

	public override void Awake() { }

	public override Rect DisplayDebugGUI(int x, int y, int barWidth, int barHeight, int separation, Texture debugTexture) { }

	public void EnsureRegistered() { }

	public override string get_LastManagerName() { }

	public override VisManager get_Manager() { }

	public float get_MaxValue() { }

	public float get_MinValue() { }

	public float GetAdjustedValueDifference() { }

	public float GetCurrentValue() { }

	public override float GetCustomControllerValue() { }

	public float GetPreviousValue() { }

	public float GetValueDifference() { }

	public override void OnDestroy() { }

	public override void Reset() { }

	public static bool RestoreVisBaseControllerTarget(IVisBaseControllerTarget target) { }

	public override void set_Manager(VisManager value) { }

	public override void Start() { }

	public virtual string ToString() { }

	public void Update() { }

	public bool ValidateManager(bool displayWarning) { }

}

