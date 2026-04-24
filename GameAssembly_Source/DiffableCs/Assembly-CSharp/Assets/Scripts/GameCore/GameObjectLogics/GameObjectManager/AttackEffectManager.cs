namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectManager;

public class AttackEffectManager : SerializedMonoBehaviour, IPause, IRelease
{
	[CompilerGenerated]
	private static AttackEffectManager <instance>k__BackingField; //Field offset: 0x0
	public const int COMBO_CHANGE_LIM = 20; //Field offset: 0x0
	public GameObject zombiaSkill; //Field offset: 0x58
	private Effect[] m_Effects; //Field offset: 0x60
	private Single[] playResultOffset; //Field offset: 0x68
	private List<ParticleSystem> m_ParticleSystemList; //Field offset: 0x70
	private ParticleSystem[] m_ParticleLongPress; //Field offset: 0x78
	private List<Behaviour> m_PauseComponents; //Field offset: 0x80
	[CompilerGenerated]
	private GameObject <elfinRecoveryEffect>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private GameObject <roleRecoveryEffect>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private GameObject <jokerSkillEffect>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private GameObject <jokerEndSkillEffect>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private GameObject <zombieSkillEffect>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private GameObject <nekoSkillEffect>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private GameObject <switchRockEffect>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private GameObject <switchSleepEffect>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private GameObject <sleepSkillEffect>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private Effect <carrotRobotSkillEffect>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private Effect <rampageSkillEffect>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private Effect <clearSkillEffect>k__BackingField; //Field offset: 0xE0
	private GameObject m_PlayResult; //Field offset: 0xE8
	private MusicData m_Playmd; //Field offset: 0xF0
	private bool m_PlayIsAir; //Field offset: 0x248
	private bool m_PlayIsBossNearAtk; //Field offset: 0x249
	public SpriteRenderer sprGameSceneHide; //Field offset: 0x250
	public List<AttackEffects> effects; //Field offset: 0x258

	public private Effect carrotRobotSkillEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private Effect clearSkillEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private GameObject elfinRecoveryEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private static AttackEffectManager instance
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public private GameObject jokerEndSkillEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private GameObject jokerSkillEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private GameObject nekoSkillEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private Effect rampageSkillEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private GameObject roleRecoveryEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private GameObject sleepSkillEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private GameObject switchRockEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private GameObject switchSleepEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private GameObject zombieSkillEffect
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public AttackEffectManager() { }

	private void Awake() { }

	private void Clean() { }

	[CompilerGenerated]
	public Effect get_carrotRobotSkillEffect() { }

	[CompilerGenerated]
	public Effect get_clearSkillEffect() { }

	[CompilerGenerated]
	public GameObject get_elfinRecoveryEffect() { }

	[CompilerGenerated]
	public static AttackEffectManager get_instance() { }

	public override bool get_IsGlobal() { }

	[CompilerGenerated]
	public GameObject get_jokerEndSkillEffect() { }

	[CompilerGenerated]
	public GameObject get_jokerSkillEffect() { }

	[CompilerGenerated]
	public GameObject get_nekoSkillEffect() { }

	[CompilerGenerated]
	public Effect get_rampageSkillEffect() { }

	[CompilerGenerated]
	public GameObject get_roleRecoveryEffect() { }

	[CompilerGenerated]
	public GameObject get_sleepSkillEffect() { }

	[CompilerGenerated]
	public GameObject get_switchRockEffect() { }

	[CompilerGenerated]
	public GameObject get_switchSleepEffect() { }

	[CompilerGenerated]
	public GameObject get_zombieSkillEffect() { }

	private void GetComps(List<ParticleSystem> particleBuffer, List<Behaviour> buffer, GameObject go) { }

	private string GetFeverName() { }

	public void Init() { }

	public void InitAttackSkillFx() { }

	private void OnComboChanged(int combo) { }

	private void OnDestroy() { }

	private void OnFail() { }

	public override void Pause(bool pauseCorountine) { }

	public void PlayAttackEffect(uint resultCode, int idx) { }

	public override void Release(bool isEditor) { }

	public static void ReleaseReferences() { }

	public override void Resume() { }

	[CompilerGenerated]
	private void set_carrotRobotSkillEffect(Effect value) { }

	[CompilerGenerated]
	private void set_clearSkillEffect(Effect value) { }

	[CompilerGenerated]
	private void set_elfinRecoveryEffect(GameObject value) { }

	[CompilerGenerated]
	private static void set_instance(AttackEffectManager value) { }

	[CompilerGenerated]
	private void set_jokerEndSkillEffect(GameObject value) { }

	[CompilerGenerated]
	private void set_jokerSkillEffect(GameObject value) { }

	[CompilerGenerated]
	private void set_nekoSkillEffect(GameObject value) { }

	[CompilerGenerated]
	private void set_rampageSkillEffect(Effect value) { }

	[CompilerGenerated]
	private void set_roleRecoveryEffect(GameObject value) { }

	[CompilerGenerated]
	private void set_sleepSkillEffect(GameObject value) { }

	[CompilerGenerated]
	private void set_switchRockEffect(GameObject value) { }

	[CompilerGenerated]
	private void set_switchSleepEffect(GameObject value) { }

	[CompilerGenerated]
	private void set_zombieSkillEffect(GameObject value) { }

	public void SetEffectAndFeverByCharacter(int roleIndex) { }

}

