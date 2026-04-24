//Type is in global namespace

public abstract class VisBaseTrigger : MonoBehaviour, IVisManagerTarget, IVisBaseControllerTarget
{
	internal static class Defaults
	{
		public const TriggerType triggerType = 4; //Field offset: 0x0
		public const float triggerThreshold = 0.1; //Field offset: 0x0
		public const float triggerReactivateDelay = 0.25; //Field offset: 0x0
		public const float triggerRandomReactivateDelay = 0; //Field offset: 0x0

	}

	internal enum TriggerType
	{
		None = 0,
		LessThanValueThreshold = 1,
		GreaterThanValueThreshold = 2,
		LessThanChangeThreshold = 3,
		GreaterThanChangeThreshold = 4,
	}

	[SerializeField]
	private VisManager m_oVisManager; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private string m_szLastVisManagerName; //Field offset: 0x20
	[SerializeField]
	private VisBaseController controller; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private string m_szLastControllerName; //Field offset: 0x30
	public TriggerType triggerType; //Field offset: 0x38
	public float triggerThreshold; //Field offset: 0x3C
	public float triggerReactivateDelay; //Field offset: 0x40
	public float triggerRandomReactivateDelay; //Field offset: 0x44
	protected float m_fTriggerDelayTimer; //Field offset: 0x48

	public override VisBaseController Controller
	{
		 get { } //Length: 5
		 set { } //Length: 175
	}

	public override string LastControllerName
	{
		 get { } //Length: 5
	}

	public override string LastManagerName
	{
		 get { } //Length: 5
	}

	public override VisManager Manager
	{
		 get { } //Length: 5
		 set { } //Length: 181
	}

	protected VisBaseTrigger() { }

	public override VisBaseController get_Controller() { }

	public override string get_LastControllerName() { }

	public override string get_LastManagerName() { }

	public override VisManager get_Manager() { }

	public override void OnDestroy() { }

	public abstract void OnTriggered(float current, float previous, float difference, float adjustedDifference) { }

	public override void Reset() { }

	public override void set_Controller(VisBaseController value) { }

	public override void set_Manager(VisManager value) { }

	public override void Start() { }

	public override void Update() { }

}

