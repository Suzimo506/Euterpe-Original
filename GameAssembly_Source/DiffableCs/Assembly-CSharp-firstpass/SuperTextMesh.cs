//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SuperTextMesh : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass167_0
	{
		public string nameToSearch; //Field offset: 0x10

		public <>c__DisplayClass167_0() { }

		internal bool <PlaySound>b__0(AutoClip x) { }

	}

	[CompilerGenerated]
	private sealed class <ReadOutText>d__163 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SuperTextMesh <>4__this; //Field offset: 0x20
		public float startTime; //Field offset: 0x28
		private float <timer>5__2; //Field offset: 0x2C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ReadOutText>d__163(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <UnReadOutText>d__164 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SuperTextMesh <>4__this; //Field offset: 0x20
		private float <timer>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <UnReadOutText>d__164(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum Alignment
	{
		Left = 0,
		Center = 1,
		Right = 2,
		Justified = 3,
		ForceJustified = 4,
	}

	internal class CustomEvent : UnityEvent<String, STMTextInfo>
	{

		public CustomEvent() { }

	}

	internal enum DrawOrder
	{
		LeftToRight = 0,
		AllAtOnce = 1,
		OneWordAtATime = 2,
		Random = 3,
		RightToLeft = 4,
		ReverseLTR = 5,
	}

	internal enum PitchMode
	{
		Normal = 0,
		Single = 1,
		Random = 2,
		Perlin = 3,
	}

	internal class VertexMod : UnityEvent<Vector3[], Vector3[], Vector3[]>
	{

		public VertexMod() { }

	}

	public bool showAppearanceFoldout; //Field offset: 0x18
	public bool showMaterialFoldout; //Field offset: 0x19
	public bool showPositionFoldout; //Field offset: 0x1A
	public bool showTimingFoldout; //Field offset: 0x1B
	public bool showFunctionalityFoldout; //Field offset: 0x1C
	public bool showAudioFoldout; //Field offset: 0x1D
	public bool showEventFoldout; //Field offset: 0x1E
	private SuperTextMeshData _data; //Field offset: 0x20
	private Transform _t; //Field offset: 0x28
	private MeshFilter _f; //Field offset: 0x30
	private MeshRenderer _r; //Field offset: 0x38
	private CanvasRenderer _c; //Field offset: 0x40
	public bool uiMode; //Field offset: 0x48
	private List<STMTextInfo> info; //Field offset: 0x50
	private List<Int32> lineBreaks; //Field offset: 0x58
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[TextArea]
	public string _text; //Field offset: 0x60
	[HideInInspector]
	public string drawText; //Field offset: 0x68
	[HideInInspector]
	public string hyphenedText; //Field offset: 0x70
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Font font; //Field offset: 0x78
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Color32 color; //Field offset: 0x80
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool richText; //Field offset: 0x84
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float readDelay; //Field offset: 0x88
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float speedReadScale; //Field offset: 0x8C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool ignoreTimeScale; //Field offset: 0x90
	public bool disableAnimatedText; //Field offset: 0x91
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string drawAnimName; //Field offset: 0x98
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float unreadDelay; //Field offset: 0xA0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public DrawOrder undrawOrder; //Field offset: 0xA4
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string undrawAnimName; //Field offset: 0xA8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public AudioSource audioSource; //Field offset: 0xB0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public AudioClip[] audioClips; //Field offset: 0xB8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool stopPreviousSound; //Field offset: 0xC0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public PitchMode pitchMode; //Field offset: 0xC4
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float overridePitch; //Field offset: 0xC8
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float minPitch; //Field offset: 0xCC
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float maxPitch; //Field offset: 0xD0
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float speedReadPitch; //Field offset: 0xD4
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float perlinPitchMulti; //Field offset: 0xD8
	private bool speedReading; //Field offset: 0xDC
	private bool skippingToEnd; //Field offset: 0xDD
	[HideInInspector]
	public bool reading; //Field offset: 0xDE
	private Coroutine readRoutine; //Field offset: 0xE0
	[HideInInspector]
	public bool unreading; //Field offset: 0xE8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float size; //Field offset: 0xEC
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int quality; //Field offset: 0xF0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public FilterMode filterMode; //Field offset: 0xF4
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public FontStyle style; //Field offset: 0xF8
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Vector3 baseOffset; //Field offset: 0xFC
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float lineSpacing; //Field offset: 0x108
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float characterSpacing; //Field offset: 0x10C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float tabSize; //Field offset: 0x110
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float autoWrap; //Field offset: 0x114
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool wrapText; //Field offset: 0x118
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool breakText; //Field offset: 0x119
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool insertHyphens; //Field offset: 0x11A
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public TextAnchor anchor; //Field offset: 0x11C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Alignment alignment; //Field offset: 0x120
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int lineCountLimit; //Field offset: 0x124
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Material textMat; //Field offset: 0x128
	public Mesh textMesh; //Field offset: 0x130
	private bool areWeAnimating; //Field offset: 0x138
	[HideInInspector]
	public Vector3 rawTopLeftBounds; //Field offset: 0x13C
	[HideInInspector]
	public Vector3 rawBottomRightBounds; //Field offset: 0x148
	[HideInInspector]
	public Vector3 topLeftBounds; //Field offset: 0x154
	[HideInInspector]
	public Vector3 topRightBounds; //Field offset: 0x160
	[HideInInspector]
	public Vector3 bottomLeftBounds; //Field offset: 0x16C
	[HideInInspector]
	public Vector3 bottomRightBounds; //Field offset: 0x178
	[HideInInspector]
	public Vector3 centerBounds; //Field offset: 0x184
	public UnityEvent onCompleteEvent; //Field offset: 0x190
	public UnityEvent onUndrawnEvent; //Field offset: 0x198
	public UnityEvent onRebuildEvent; //Field offset: 0x1A0
	public CustomEvent customEvent; //Field offset: 0x1A8
	public bool modifyVertices; //Field offset: 0x1B0
	public VertexMod vertexMod; //Field offset: 0x1B8
	public bool debugMode; //Field offset: 0x1C0
	[HideInInspector]
	public float totalReadTime; //Field offset: 0x1C4
	[HideInInspector]
	public float totalUnreadTime; //Field offset: 0x1C8
	[HideInInspector]
	public float currentReadTime; //Field offset: 0x1CC
	private Vector3[] endVerts; //Field offset: 0x1D0
	private Color32[] endCol32; //Field offset: 0x1D8
	private Vector2[] endUv; //Field offset: 0x1E0
	private Vector2[] endUv2; //Field offset: 0x1E8
	private Vector3[] startVerts; //Field offset: 0x1F0
	private Color32[] startCol32; //Field offset: 0x1F8
	private Vector3[] midVerts; //Field offset: 0x200
	private Color32[] midCol32; //Field offset: 0x208
	private List<SubMeshData> subMeshes; //Field offset: 0x210
	private float timeDrawn; //Field offset: 0x218
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool autoRead; //Field offset: 0x21C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool rememberReadPosition; //Field offset: 0x21D
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public DrawOrder drawOrder; //Field offset: 0x220
	private bool callReadFunction; //Field offset: 0x224
	private int pauseCount; //Field offset: 0x228
	private int currentPauseCount; //Field offset: 0x22C
	private bool applicationFocused; //Field offset: 0x230
	public int latestNumber; //Field offset: 0x234
	public int lowestLine; //Field offset: 0x238
	private Int32[] drawOrderRTL; //Field offset: 0x240

	private float AutoWrap
	{
		private get { } //Length: 166
	}

	public CanvasRenderer c
	{
		 get { } //Length: 283
	}

	public SuperTextMeshData data
	{
		 get { } //Length: 219
		 set { } //Length: 12
	}

	public MeshFilter f
	{
		 get { } //Length: 283
	}

	public float GetDeltaTime
	{
		 get { } //Length: 95
	}

	public float GetDeltaTime2
	{
		 get { } //Length: 32
	}

	public float GetTime
	{
		 get { } //Length: 95
	}

	public MeshRenderer r
	{
		 get { } //Length: 283
	}

	public Transform t
	{
		 get { } //Length: 142
	}

	public string text
	{
		 get { } //Length: 5
		 set { } //Length: 44
	}

	public string Text
	{
		 get { } //Length: 5
		 set { } //Length: 44
	}

	private STMDrawAnimData UndrawAnim
	{
		private get { } //Length: 262
	}

	public SuperTextMesh() { }

	private FontStyle AddStyle(FontStyle original, FontStyle newStyle) { }

	public void Append(string newText) { }

	private void ApplyMaterials() { }

	private void ApplyOffsetDataToTextInfo() { }

	private void ApplyTimingDataToTextInfo() { }

	private void ApplyUnreadTimingDataToTextInfo() { }

	private bool AreColorsTheSame(Color32 col1, Color32 col2) { }

	private void ClearMaterials() { }

	public bool Continue() { }

	private SubMeshData DoesSubmeshExist(SuperTextMesh stm, STMTextInfo info) { }

	private void DoEvent(int i) { }

	private float get_AutoWrap() { }

	public CanvasRenderer get_c() { }

	public SuperTextMeshData get_data() { }

	public MeshFilter get_f() { }

	public float get_GetDeltaTime() { }

	public float get_GetDeltaTime2() { }

	public float get_GetTime() { }

	public MeshRenderer get_r() { }

	public Transform get_t() { }

	public string get_text() { }

	public string get_Text() { }

	private STMDrawAnimData get_UndrawAnim() { }

	private STMColorData GetColor(string myCol) { }

	private int GetFontSize(Font myFont, STMTextInfo myInfo) { }

	private Color32 HexToColor(string hex) { }

	private void Init() { }

	private Vector3 JitterValue(STMTextInfo myInfo, STMJitterData jit) { }

	private void OnApplicationFocus(bool focused) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	private void OnFontTextureRebuilt(Font changedFont) { }

	private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode) { }

	private void OnValidate() { }

	private string ParseText(string myText) { }

	private void PlaySound(int i) { }

	private void PrepareSubmeshes() { }

	public void Read() { }

	public void Read(float startTime) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator ReadOutText(float startTime) { }

	public void Rebuild(bool readAutomatically) { }

	public void Rebuild(float startTime) { }

	public void Rebuild(float startTime, bool readAutomatically) { }

	public void Rebuild() { }

	public static void RebuildAll() { }

	private void RebuildTextInfo() { }

	private void RecalculateBounds() { }

	public void RegularRead() { }

	private void RequestAllCharacters() { }

	public void set_data(SuperTextMeshData value) { }

	public void set_text(string value) { }

	public void set_Text(string value) { }

	private void SetMesh(float timeValue, bool undrawingMesh) { }

	private void SetMesh(float timeValue) { }

	public void ShowAllText() { }

	private void ShowAllText(bool unreadingMesh) { }

	public void SkipToEnd() { }

	private string SpecialKeyToName(char ch) { }

	public void SpeedRead() { }

	private void Start() { }

	private void StopReadRoutine() { }

	private FontStyle SubtractStyle(FontStyle original, FontStyle subStyle) { }

	public void Undraw() { }

	public void UnDraw() { }

	private void UnInit() { }

	public void Unread() { }

	public void UnRead() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator UnReadOutText() { }

	private void Update() { }

	private void UpdateDrawnMesh(float myTime, bool undrawingMesh) { }

	private void UpdateMesh() { }

	private void UpdatePreReadMesh(bool undrawingMesh) { }

	private void UpdateRTLDrawOrder() { }

	private bool ValidHexcode(string hex) { }

	private Vector3 WaveValue(STMTextInfo myInfo, STMWaveControl wave) { }

}

