//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class VisDataGroup : MonoBehaviour, IVisManagerTarget
{
	internal static class Defaults
	{
		public static int dataGroupNameCounter; //Field offset: 0x64B00
		public const string dataGroupName = "Default"; //Field offset: 0x64B2C
		public const int numberSubDataGroups = 5; //Field offset: 0x64B30
		public const int frequencyRangeStartIndex = 0; //Field offset: 0x64B77
		public const float boost = 1; //Field offset: 0x64B80
		public const float cutoff = 1; //Field offset: 0x64C01
		public const VisDataSource dataSource = 1; //Field offset: 0x2C927B4
		public const int frequencyRangeEndIndex = 256; //Field offset: 0x2C927BC

		private static Defaults() { }

	}

	[SerializeField]
	private VisManager m_oVisManager; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private string m_szLastVisManagerName; //Field offset: 0x20
	public string dataGroupName; //Field offset: 0x28
	public VisDataSource dataSource; //Field offset: 0x30
	public int numberSubDataGroups; //Field offset: 0x34
	public int frequencyRangeStartIndex; //Field offset: 0x38
	public int frequencyRangeEndIndex; //Field offset: 0x3C
	public float boost; //Field offset: 0x40
	public float cutoff; //Field offset: 0x44
	public Color debugColor; //Field offset: 0x48
	private VisDataContainer[] m_aoDataContainers; //Field offset: 0x58
	private List<VisSubDataGroup> m_oSubDataGroups; //Field offset: 0x60

	public override string LastManagerName
	{
		 get { } //Length: 5
	}

	public override VisManager Manager
	{
		 get { } //Length: 5
		 set { } //Length: 336
	}

	public VisDataGroup() { }

	public void Awake() { }

	public Rect DisplayDebugGUI(int x, int y, int barWidth, int barHeight, int separation, Texture debugTexture) { }

	public void EnsureRegistered() { }

	public override string get_LastManagerName() { }

	public override VisManager get_Manager() { }

	public float GetPreviousValue(VisDataValueType finalValueType, VisDataValueType subValueType) { }

	public float GetValue(VisDataValueType finalValueType, VisDataValueType subValueType) { }

	public float GetValueDifference(VisDataValueType finalValueType, VisDataValueType subValueType) { }

	public void OnDestroy() { }

	public void Reset() { }

	public static bool RestoreVisDataGroupTarget(IVisDataGroupTarget target) { }

	public override void set_Manager(VisManager value) { }

	public void Start() { }

	public virtual string ToString() { }

	private void Update() { }

	public bool ValidateManager(bool displayWarning) { }

}

