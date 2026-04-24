namespace DG.Tweening;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DOTweenPath : ABSAnimationComponent
{
	[CompilerGenerated]
	private static Action<DOTweenPath> OnReset; //Field offset: 0x0
	private static MethodInfo _miCreateTween; //Field offset: 0x8
	public float delay; //Field offset: 0x68
	public float duration; //Field offset: 0x6C
	public Ease easeType; //Field offset: 0x70
	public AnimationCurve easeCurve; //Field offset: 0x78
	public int loops; //Field offset: 0x80
	public string id; //Field offset: 0x88
	public LoopType loopType; //Field offset: 0x90
	public OrientType orientType; //Field offset: 0x94
	public Transform lookAtTransform; //Field offset: 0x98
	public Vector3 lookAtPosition; //Field offset: 0xA0
	public float lookAhead; //Field offset: 0xAC
	public bool autoPlay; //Field offset: 0xB0
	public bool autoKill; //Field offset: 0xB1
	public bool relative; //Field offset: 0xB2
	public bool isLocal; //Field offset: 0xB3
	public bool isClosedPath; //Field offset: 0xB4
	public int pathResolution; //Field offset: 0xB8
	public PathMode pathMode; //Field offset: 0xBC
	public AxisConstraint lockRotation; //Field offset: 0xC0
	public bool assignForwardAndUp; //Field offset: 0xC4
	public Vector3 forwardDirection; //Field offset: 0xC8
	public Vector3 upDirection; //Field offset: 0xD4
	public bool tweenRigidbody; //Field offset: 0xE0
	public List<Vector3> wps; //Field offset: 0xE8
	public List<Vector3> fullWps; //Field offset: 0xF0
	public Path path; //Field offset: 0xF8
	public DOTweenInspectorMode inspectorMode; //Field offset: 0x100
	public PathType pathType; //Field offset: 0x104
	public HandlesType handlesType; //Field offset: 0x108
	public bool livePreview; //Field offset: 0x10C
	public HandlesDrawMode handlesDrawMode; //Field offset: 0x110
	public float perspectiveHandleSize; //Field offset: 0x114
	public bool showIndexes; //Field offset: 0x118
	public bool showWpLength; //Field offset: 0x119
	public Color pathColor; //Field offset: 0x11C
	public Vector3 lastSrcPosition; //Field offset: 0x12C
	public Quaternion lastSrcRotation; //Field offset: 0x138
	public bool wpsDropdown; //Field offset: 0x148
	public float dropToFloorOffset; //Field offset: 0x14C

	public static event Action<DOTweenPath> OnReset
	{
		[CompilerGenerated]
		 add { } //Length: 164
		[CompilerGenerated]
		 remove { } //Length: 164
	}

	public DOTweenPath() { }

	[CompilerGenerated]
	private void <Awake>b__44_0() { }

	[CompilerGenerated]
	public static void add_OnReset(Action<DOTweenPath> value) { }

	private void Awake() { }

	private static void Dispatch_OnReset(DOTweenPath path) { }

	public virtual void DOComplete() { }

	public virtual void DOKill() { }

	public virtual void DOPause() { }

	public virtual void DOPlay() { }

	public virtual void DOPlayBackwards() { }

	public virtual void DOPlayForward() { }

	public virtual void DORestart(bool fromHere) { }

	public virtual void DORestart() { }

	public virtual void DORewind() { }

	public virtual void DOTogglePause() { }

	public Vector3[] GetDrawPoints() { }

	internal Vector3[] GetFullWps() { }

	public Tween GetTween() { }

	private void OnDestroy() { }

	private void ReEvaluateRelativeTween() { }

	[CompilerGenerated]
	public static void remove_OnReset(Action<DOTweenPath> value) { }

	private void Reset() { }

}

