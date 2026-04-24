//Type is in global namespace

public class NoteFollow : MonoBehaviour, IFastPoolItem, IPause
{
	private ParticleSystem[] particles; //Field offset: 0x18
	public float duration; //Field offset: 0x20
	public float m_Progress; //Field offset: 0x24
	public AnimationCurve animCurve; //Field offset: 0x28
	private Action m_Callback; //Field offset: 0x30
	public float speed; //Field offset: 0x38
	private SkeletonAnimation m_Skeleton; //Field offset: 0x40
	private Vector3 m_TargetPosition; //Field offset: 0x48
	private float m_Tick; //Field offset: 0x54
	private Vector3 m_Distance; //Field offset: 0x58
	private Transform m_TargetTransform; //Field offset: 0x68
	private SkeletonRendererCustomMaterials m_CustomMaterials; //Field offset: 0x70
	public double InvokeDistance; //Field offset: 0x78
	private bool isPause; //Field offset: 0x80
	[CompilerGenerated]
	private bool <IsGlobal>k__BackingField; //Field offset: 0x81

	public private override bool IsGlobal
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Vector3 targetPosition
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public NoteFollow() { }

	public void Awake() { }

	[CompilerGenerated]
	public override bool get_IsGlobal() { }

	public Vector3 get_targetPosition() { }

	public void Init(Vector3 startPosition, Transform targeTransform) { }

	public void OnDisable() { }

	public void OnEnable() { }

	public override void OnFastDestroy() { }

	public override void OnFastInstantiate() { }

	private void OnUpdate() { }

	public override void Pause(bool pauseCorountine) { }

	private void ResetField() { }

	public override void Resume() { }

	[CompilerGenerated]
	private void set_IsGlobal(bool value) { }

	public void set_targetPosition(Vector3 value) { }

	public void SetCallback(Action callback) { }

	private void Update() { }

	private void UpdateDistance() { }

}

