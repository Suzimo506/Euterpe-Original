namespace GameLogic;

public class GameMusicScene : IPause
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<IData> <>9__68_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SetGameBrightnessColor>b__68_0(IData b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public decimal tick; //Field offset: 0x10

		public <>c__DisplayClass73_0() { }

		internal bool <SceneEventTrigger>b__0(SceneEvent s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public GameObject preObj; //Field offset: 0x10

		public <>c__DisplayClass79_0() { }

		internal bool <PreloadGameObject>b__0(NoteConfigData n) { }

	}

	private struct Node
	{
		public Transform current; //Field offset: 0x0
		public int currentId; //Field offset: 0x8
		public int countOfThisLine; //Field offset: 0xC

	}

	private static GameObject sceneChangeObj; //Field offset: 0x0
	public FixUpdateTimer stepTimer; //Field offset: 0x10
	public GameObject[] preloads; //Field offset: 0x18
	public NodeInitController[] nodeInitCtrls; //Field offset: 0x20
	public SpineActionController[] spineActionCtrls; //Field offset: 0x28
	public BaseSpineObjectController[] objCtrls; //Field offset: 0x30
	public Animator[] animators; //Field offset: 0x38
	public SkeletonAnimation[] animations; //Field offset: 0x40
	public SpineMountController[] spineMountCtrls; //Field offset: 0x48
	public List<GameObject>[] preloads1; //Field offset: 0x50
	public List<NodeInitController>[] nodeInitCtrls1; //Field offset: 0x58
	public List<SpineActionController>[] spineActionCtrls1; //Field offset: 0x60
	public List<BaseSpineObjectController>[] objCtrls1; //Field offset: 0x68
	public List<Animator>[] animators1; //Field offset: 0x70
	public List<SkeletonAnimation>[] animations1; //Field offset: 0x78
	public List<SpineMountController>[] spineMountCtrls1; //Field offset: 0x80
	public List<Boolean>[] showEffects; //Field offset: 0x88
	public bool firstIn; //Field offset: 0x90
	[CompilerGenerated]
	private GameObject <scene>k__BackingField; //Field offset: 0x98
	public List<GameObject> scenes; //Field offset: 0xA0
	public string curSceneName; //Field offset: 0xA8
	private Dictionary<Int32, SceneSubControl> m_SceneSubControls; //Field offset: 0xB0
	[CompilerGenerated]
	private Material <catchMaterial>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private Sprite <catchGroundSprite>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Sprite <catchAirSprite>k__BackingField; //Field offset: 0xC8
	private Color m_GroundCatchCircleColor; //Field offset: 0xD0
	private Color m_GroundCatchCircle2Color; //Field offset: 0xE0
	private Color m_AirCatchCircleColor; //Field offset: 0xF0
	private Color m_AirCatchCircle2Color; //Field offset: 0x100
	public int passIdx; //Field offset: 0x110
	public int prePassIdx; //Field offset: 0x114

	public private Color airCatchCircle2Color
	{
		 get { } //Length: 14
		private set { } //Length: 11
	}

	public private Color airCatchCircleColor
	{
		 get { } //Length: 14
		private set { } //Length: 11
	}

	public private Sprite catchAirSprite
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private Sprite catchGroundSprite
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private Material catchMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private Color groundCatchCircle2Color
	{
		 get { } //Length: 14
		private set { } //Length: 11
	}

	public private Color groundCatchCircleColor
	{
		 get { } //Length: 14
		private set { } //Length: 11
	}

	public static GameMusicScene instance
	{
		 get { } //Length: 87
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public private GameObject scene
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public GameObject SecneObject
	{
		 get { } //Length: 67
	}

	public GameMusicScene() { }

	public void AddObjTrigger(decimal genTick) { }

	private void DialogEventTrigger(decimal tick) { }

	public Color get_airCatchCircle2Color() { }

	public Color get_airCatchCircleColor() { }

	[CompilerGenerated]
	public Sprite get_catchAirSprite() { }

	[CompilerGenerated]
	public Sprite get_catchGroundSprite() { }

	[CompilerGenerated]
	public Material get_catchMaterial() { }

	public Color get_groundCatchCircle2Color() { }

	public Color get_groundCatchCircleColor() { }

	public static GameMusicScene get_instance() { }

	public override bool get_IsGlobal() { }

	[CompilerGenerated]
	public GameObject get_scene() { }

	public GameObject get_SecneObject() { }

	public Animator GetAnimator(int index) { }

	public BaseSpineObjectController GetObjCtrl(int index) { }

	public GameObject GetPreLoadGameObject(int idx) { }

	public GameObject GetPreloads(int index) { }

	public SpineActionController GetSpineCtrl(int index) { }

	private void InitDialogEvent() { }

	private void InitEventTrigger() { }

	private void InitSceneEvents() { }

	private void InitSceneObject(string name, bool isActive = false) { }

	private void InitTimer(decimal total) { }

	public void LoadScene(string sceneName) { }

	public override void Pause(bool pauseCorountine) { }

	public GameObject PreLoad(int idx) { }

	private void PreLoadEnemy() { }

	private GameObject PreloadGameObject(GameObject preObj, MusicData md, int curScene, bool hasSceneChange) { }

	private GameObject PreloadTmpGameObject(GameObject go, MusicData md, int curScene) { }

	public void ReleaseReferences() { }

	public void ReplaceEnemy(int idx, int curScene) { }

	public void ResetTimer() { }

	public override void Resume() { }

	public void Run() { }

	public void SceneEventTrigger(decimal tick) { }

	private string SceneFestival(string sceneFestivalName) { }

	private void set_airCatchCircle2Color(Color value) { }

	private void set_airCatchCircleColor(Color value) { }

	[CompilerGenerated]
	private void set_catchAirSprite(Sprite value) { }

	[CompilerGenerated]
	private void set_catchGroundSprite(Sprite value) { }

	[CompilerGenerated]
	private void set_catchMaterial(Material value) { }

	private void set_groundCatchCircle2Color(Color value) { }

	private void set_groundCatchCircleColor(Color value) { }

	[CompilerGenerated]
	private void set_scene(GameObject value) { }

	public void SetBgFreeze(bool freeze) { }

	private void SetGameBrightnessColor() { }

	public void SetTimer(FixUpdateTimer timer) { }

	public void Stop() { }

}

