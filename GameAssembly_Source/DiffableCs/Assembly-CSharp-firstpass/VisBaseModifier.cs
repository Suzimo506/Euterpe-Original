//Type is in global namespace

public abstract class VisBaseModifier : MonoBehaviour, IVisManagerTarget, IVisBaseControllerTarget
{
	internal static class Defaults
	{

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

	protected VisBaseModifier() { }

	public override VisBaseController get_Controller() { }

	public override string get_LastControllerName() { }

	public override string get_LastManagerName() { }

	public override VisManager get_Manager() { }

	public override void OnDestroy() { }

	public abstract void OnValueUpdated(float current, float previous, float difference, float adjustedDifference) { }

	public override void Reset() { }

	public override void set_Controller(VisBaseController value) { }

	public override void set_Manager(VisManager value) { }

	public override void Start() { }

	public void Update() { }

}

