namespace DG.Tweening;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DOTweenAnimation : ABSAnimationComponent
{
	internal enum AnimationType
	{
		None = 0,
		Move = 1,
		LocalMove = 2,
		Rotate = 3,
		LocalRotate = 4,
		Scale = 5,
		Color = 6,
		Fade = 7,
		Text = 8,
		PunchPosition = 9,
		PunchRotation = 10,
		PunchScale = 11,
		ShakePosition = 12,
		ShakeRotation = 13,
		ShakeScale = 14,
		CameraAspect = 15,
		CameraBackgroundColor = 16,
		CameraFieldOfView = 17,
		CameraOrthoSize = 18,
		CameraPixelRect = 19,
		CameraRect = 20,
		UIWidthHeight = 21,
	}

	internal enum TargetType
	{
		Unset = 0,
		Camera = 1,
		CanvasGroup = 2,
		Image = 3,
		Light = 4,
		RectTransform = 5,
		Renderer = 6,
		SpriteRenderer = 7,
		Rigidbody = 8,
		Rigidbody2D = 9,
		Text = 10,
		Transform = 11,
		tk2dBaseSprite = 12,
		tk2dTextMesh = 13,
		TextMeshPro = 14,
		TextMeshProUGUI = 15,
	}

	[CompilerGenerated]
	private static Action<DOTweenAnimation> OnReset; //Field offset: 0x0
	public bool targetIsSelf; //Field offset: 0x68
	public GameObject targetGO; //Field offset: 0x70
	public bool tweenTargetIsTargetGO; //Field offset: 0x78
	public float delay; //Field offset: 0x7C
	public float duration; //Field offset: 0x80
	public Ease easeType; //Field offset: 0x84
	public AnimationCurve easeCurve; //Field offset: 0x88
	public LoopType loopType; //Field offset: 0x90
	public int loops; //Field offset: 0x94
	public string id; //Field offset: 0x98
	public bool isRelative; //Field offset: 0xA0
	public bool isFrom; //Field offset: 0xA1
	public bool isIndependentUpdate; //Field offset: 0xA2
	public bool autoKill; //Field offset: 0xA3
	public bool isActive; //Field offset: 0xA4
	public bool isValid; //Field offset: 0xA5
	public Component target; //Field offset: 0xA8
	public AnimationType animationType; //Field offset: 0xB0
	public TargetType targetType; //Field offset: 0xB4
	public TargetType forcedTargetType; //Field offset: 0xB8
	public bool autoPlay; //Field offset: 0xBC
	public bool useTargetAsV3; //Field offset: 0xBD
	public float endValueFloat; //Field offset: 0xC0
	public Vector3 endValueV3; //Field offset: 0xC4
	public Vector2 endValueV2; //Field offset: 0xD0
	public Color endValueColor; //Field offset: 0xD8
	public string endValueString; //Field offset: 0xE8
	public Rect endValueRect; //Field offset: 0xF0
	public Transform endValueTransform; //Field offset: 0x100
	public bool optionalBool0; //Field offset: 0x108
	public float optionalFloat0; //Field offset: 0x10C
	public int optionalInt0; //Field offset: 0x110
	public RotateMode optionalRotationMode; //Field offset: 0x114
	public ScrambleMode optionalScrambleMode; //Field offset: 0x118
	public string optionalString; //Field offset: 0x120
	private bool _tweenCreated; //Field offset: 0x128
	private int _playCount; //Field offset: 0x12C

	public static event Action<DOTweenAnimation> OnReset
	{
		[CompilerGenerated]
		 add { } //Length: 164
		[CompilerGenerated]
		 remove { } //Length: 164
	}

	public DOTweenAnimation() { }

	[CompilerGenerated]
	private void <CreateTween>b__47_0() { }

	[CompilerGenerated]
	public static void add_OnReset(Action<DOTweenAnimation> value) { }

	private void Awake() { }

	public Tween CreateEditorPreview() { }

	public void CreateTween() { }

	private static void Dispatch_OnReset(DOTweenAnimation anim) { }

	public virtual void DOComplete() { }

	public virtual void DOKill() { }

	public virtual void DOPause() { }

	public void DOPauseAllById(string id) { }

	public virtual void DOPlay() { }

	public void DOPlayAllById(string id) { }

	public virtual void DOPlayBackwards() { }

	public void DOPlayBackwardsAllById(string id) { }

	public void DOPlayBackwardsById(string id) { }

	public void DOPlayById(string id) { }

	public virtual void DOPlayForward() { }

	public void DOPlayForwardAllById(string id) { }

	public void DOPlayForwardById(string id) { }

	public void DOPlayNext() { }

	public virtual void DORestart(bool fromHere) { }

	public virtual void DORestart() { }

	public void DORestartAllById(string id) { }

	public void DORestartById(string id) { }

	public virtual void DORewind() { }

	public void DORewindAllById(string id) { }

	public void DORewindAndPlayNext() { }

	public virtual void DOTogglePause() { }

	private GameObject GetTweenGO() { }

	public List<Tween> GetTweens() { }

	private void OnDestroy() { }

	private void ReEvaluateRelativeTween() { }

	[CompilerGenerated]
	public static void remove_OnReset(Action<DOTweenAnimation> value) { }

	private void Reset() { }

	private void Start() { }

	public static TargetType TypeToDOTargetType(Type t) { }

}

