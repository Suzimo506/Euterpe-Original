//Type is in global namespace

public class SpineActionController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<SpriteRenderer> <>9__58_0; //Field offset: 0x8
		public static Predicate<SpriteRenderer> <>9__58_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__58_0(SpriteRenderer s) { }

		internal bool <Init>b__58_1(SpriteRenderer s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		public decimal showTick; //Field offset: 0x10
		public float totalTime; //Field offset: 0x20
		public float startPos; //Field offset: 0x24
		public float endPos; //Field offset: 0x28
		public string id; //Field offset: 0x30
		public SpineActionController <>4__this; //Field offset: 0x38

		public <>c__DisplayClass75_0() { }

		internal void <OnControllerStart>b__0(float d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public string actionKey; //Field offset: 0x10

		public <>c__DisplayClass77_0() { }

		internal bool <PlayAnimator>b__0(AnimationClip a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public GameObject obj; //Field offset: 0x10

		public <>c__DisplayClass79_0() { }

		internal bool <Play>b__0(GameObject g) { }

	}

	private static bool s_InitFlag; //Field offset: 0x0
	public static List<ParticleSystem> groundClipParticles; //Field offset: 0x8
	public static List<ParticleSystem> airClipParticles; //Field offset: 0x10
	private static UnityGameManager s_UnityGameManger; //Field offset: 0x18
	private static Dictionary<Transform, GameObject> m_Stars; //Field offset: 0x20
	public static List<Tweener> starTweeners; //Field offset: 0x28
	private static Dictionary<GameObject, String> s_LongDestroyClipName; //Field offset: 0x30
	private BaseSpineObjectController m_ObjController; //Field offset: 0x18
	private int m_ProtectLevel; //Field offset: 0x20
	private string m_CurrentActionName; //Field offset: 0x28
	private SkeletonAnimation m_SkeletonAnimation; //Field offset: 0x30
	private Dictionary<String, Bone> m_Bones; //Field offset: 0x38
	private Dictionary<Int32, DoNothing> m_DoNothings; //Field offset: 0x40
	private List<GameObject> m_SyncObjectsBuffer; //Field offset: 0x48
	private List<Animator> m_SyncAnimatorBuffers; //Field offset: 0x50
	private List<SpineActionController> m_SyncSpineActionControllerBuffers; //Field offset: 0x58
	[SerializeField]
	public SkeletActionData[] actionData; //Field offset: 0x60
	public int actionMode; //Field offset: 0x68
	public float startDelay; //Field offset: 0x6C
	public float duration; //Field offset: 0x70
	public float scale; //Field offset: 0x74
	public float lengthRate; //Field offset: 0x78
	public GameObject rendererPreb; //Field offset: 0x80
	public GameObject destroyEffect; //Field offset: 0x88
	public GameObject clipEffect; //Field offset: 0x90
	private GameObject m_CatchObj; //Field offset: 0x98
	public float rotateRuration; //Field offset: 0xA0
	private Material m_Mtrl; //Field offset: 0xA8
	private Renderer m_Renderer; //Field offset: 0xB0
	private decimal m_Length; //Field offset: 0xB8
	private int m_Idx; //Field offset: 0xC8
	private bool m_HasDestroy; //Field offset: 0xCC
	private bool m_HasAlpha; //Field offset: 0xCD
	private MusicData m_MusicData; //Field offset: 0xD0
	private SpriteRenderer m_StartStar; //Field offset: 0x228
	private SpriteRenderer m_EndStar; //Field offset: 0x230
	private int m_SceneIdx; //Field offset: 0x238
	[CompilerGenerated]
	private string <curActionKey>k__BackingField; //Field offset: 0x240
	private bool m_IsPause; //Field offset: 0x248
	public Animator animator; //Field offset: 0x250
	private Animation m_Animation; //Field offset: 0x258
	private ParticleSystem[] m_NoteEffects; //Field offset: 0x260
	private float m_StarSpeed; //Field offset: 0x268

	public Dictionary<String, Bone> bones
	{
		 get { } //Length: 5
	}

	public private string curActionKey
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public string currentActionName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string currentAnimationName
	{
		 get { } //Length: 132
	}

	public private float currentAnimationTime
	{
		 get { } //Length: 165
		private set { } //Length: 164
	}

	public BaseSpineObjectController objController
	{
		 get { } //Length: 5
	}

	public int protectLevel
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float ShowTick
	{
		 get { } //Length: 112
	}

	public SkeletonAnimation skeletonAnimation
	{
		 get { } //Length: 5
	}

	private static SpineActionController() { }

	public SpineActionController() { }

	[CompilerGenerated]
	private float <SetAlpha>b__71_0() { }

	[CompilerGenerated]
	private void <SetAlpha>b__71_1(float a) { }

	[CompilerGenerated]
	private Color <SetAlpha>b__71_2() { }

	[CompilerGenerated]
	private void <SetAlpha>b__71_3(Color a) { }

	[CompilerGenerated]
	private Color <SetAlpha>b__71_4() { }

	[CompilerGenerated]
	private void <SetAlpha>b__71_5(Color a) { }

	private TrackEntry AddAnimation(string n, bool isLoop, float delay) { }

	private void Awake() { }

	private bool CheckActionProtect(SkeletActionData data) { }

	private void ClearTracks() { }

	public void Clip(float percent, uint result) { }

	public static string CurrentAnimationName(int idx) { }

	public void DestroyLongPress() { }

	private void DoctorSkInit(SkeletonAnimation ska) { }

	public void FixSpineAnim() { }

	public void ForceUpdateSkAnim(bool lateUpdate = false) { }

	public Dictionary<String, Bone> get_bones() { }

	[CompilerGenerated]
	public string get_curActionKey() { }

	public string get_currentActionName() { }

	public string get_currentAnimationName() { }

	public float get_currentAnimationTime() { }

	public BaseSpineObjectController get_objController() { }

	public int get_protectLevel() { }

	public float get_ShowTick() { }

	public SkeletonAnimation get_skeletonAnimation() { }

	public static Vector3 GetBoneAbsPosition(string boneName, GameObject obj) { }

	public static Vector3 GetBoneRealPosition(string boneName, GameObject obj) { }

	public void Init(int idx, int curScene) { }

	private void InitEffect() { }

	private void InitSkField(SkeletonAnimation ska) { }

	public bool IsLongPressAlpha() { }

	public bool IsLongPressDestroy() { }

	private void JkSkillInit() { }

	public void OnControllerStart() { }

	private void OnDestroy() { }

	private void OnNoteDisappear(object sender, object reciever, Object[] args) { }

	public void Pause() { }

	public static void Play(string actionKey, int idx, float tick = 0, bool isOverride = true) { }

	public static void Play(string actionKey, GameObject obj, float tick = 0, SpineActionController sac = null, Animator animator = null, bool isOverride = true) { }

	private static void PlayAnimator(string actionKey, GameObject obj, Animator animator = null) { }

	public static void PlayAnimator(string actionKey, int idx, int layer = 0, float tick = 0, bool isOverride = true) { }

	public void PlayByData(SkeletActionData data, bool isOverride = true) { }

	public void PlayByKey(string actionKey, bool isOverride = true) { }

	public void PlayDestroyEffect() { }

	public static void PlayLongPressEffect(bool isTo, bool isAir = false) { }

	public static void PlaySkeleton(string actionKey, int idx) { }

	public static void PlaySkeletonAnim(string actionKey, int idx, bool isLoop = false, bool isOverride = true, float delay = 0, float time = -1) { }

	public static void ReleaseReferences() { }

	public void Resume() { }

	[CompilerGenerated]
	private void set_curActionKey(string value) { }

	public void set_currentActionName(string value) { }

	private void set_currentAnimationTime(float value) { }

	public void set_protectLevel(int value) { }

	public void SetAlpha(float alpha) { }

	public TrackEntry SetAnimation(string n, bool isLoop) { }

	public void SetLength(decimal time) { }

	public static void SetSynchroObjectsActive(GameObject obj, bool val) { }

	private void SetSyncObjects(List<GameObject> syncObjs) { }

	public void StopStar() { }

	public static void StopStars() { }

}

