using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using GameLogic;
using Spine;
using Spine.Unity;
using UnityEngine;

[Token(Token = "0x2000015")]
public class SpineActionController : MonoBehaviour
{
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x18")]
	private BaseSpineObjectController m_ObjController;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004E")]
	private int m_ProtectLevel;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004F")]
	private string m_CurrentActionName;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x30")]
	private string m_CurrentSpineActionName;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000051")]
	private SkeletonAnimation m_SkeletonAnimation;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000052")]
	private Dictionary<string, Bone> m_Bones;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, DoNothing> m_DoNothings;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x50")]
	private SyncObjectsBuffer m_SyncObjectsBuffer;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000055")]
	[SerializeField]
	public SkeletActionData[] actionData;

	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000056")]
	private SkeletActionData[] m_FeverActionData;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x88")]
	public int actionMode;

	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000058")]
	public float startDelay;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000059")]
	public float duration;

	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400005A")]
	public float scale;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400005B")]
	public float lengthRate;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400005C")]
	public GameObject rendererPreb;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400005D")]
	public GameObject destroyEffect;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject clipEffect;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject m_CatchObj;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0xC0")]
	public float rotateRuration;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000061")]
	private Material m_Mtrl;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000062")]
	private Renderer m_Renderer;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0xD8")]
	private decimal m_Length;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0xE8")]
	private int m_Idx;

	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000065")]
	private bool m_HasDestroy;

	[FieldOffset(Offset = "0xED")]
	[Token(Token = "0x4000066")]
	private bool m_HasAlpha;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000067")]
	private MusicData m_MusicData;

	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000068")]
	private SpriteRenderer m_StartStar;

	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000069")]
	private SpriteRenderer m_EndStar;

	[Token(Token = "0x400006A")]
	private static UnityGameManager s_UnityGameManger;

	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400006B")]
	private int m_SceneIdx;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x270")]
	private bool m_IsPause;

	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400006E")]
	public Animator animator;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x280")]
	private UnityEngine.Animation m_Animation;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x288")]
	private ParticleSystem[] m_NoteEffects;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x290")]
	private float m_StarSpeed;

	[Token(Token = "0x17000008")]
	public Dictionary<string, Bone> bones
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	public List<GameObject> syncObjects
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[Token(Token = "0x6000052")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public List<SpineActionController> SyncSacs
	{
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		[Token(Token = "0x6000053")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	public SyncObjectsBuffer SyncBuffer
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x514940", Offset = "0x513140", Length = "0x1D")]
		get
		{
			return default(SyncObjectsBuffer);
		}
	}

	[Token(Token = "0x1700000C")]
	public string curActionKey
	{
		[CompilerGenerated]
		[Address(RVA = "0x514960", Offset = "0x513160", Length = "0x8")]
		[Token(Token = "0x6000056")]
		get
		{
			return null;
		}
		[Address(RVA = "0x514AB0", Offset = "0x5132B0", Length = "0xF")]
		[Token(Token = "0x6000055")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public SkeletonAnimation skeletonAnimation
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public BaseSpineObjectController objController
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6000058")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	public float ShowTick
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5148C0", Offset = "0x5130C0", Length = "0x73")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000010")]
	public float currentAnimationTime
	{
		[Address(RVA = "0x514A00", Offset = "0x513200", Length = "0xA5")]
		[Token(Token = "0x600007A")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x514AC0", Offset = "0x5132C0", Length = "0xA8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public int protectLevel
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
		[Token(Token = "0x6000084")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public string currentActionName
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public string currentAnimationName
	{
		[Address(RVA = "0x514970", Offset = "0x513170", Length = "0x84")]
		[Token(Token = "0x6000088")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x513330", Offset = "0x511B30", Length = "0x48")]
	[Token(Token = "0x600005A")]
	public static void ReleaseReferences()
	{
	}

	[Address(RVA = "0x50DDC0", Offset = "0x50C5C0", Length = "0x1A0")]
	[Token(Token = "0x600005B")]
	private void Awake()
	{
	}

	[Address(RVA = "0x510980", Offset = "0x50F180", Length = "0xE0")]
	[Token(Token = "0x600005C")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x50F030", Offset = "0x50D830", Length = "0x120")]
	[Token(Token = "0x600005D")]
	private void InitEffect()
	{
	}

	[Address(RVA = "0x50EEC0", Offset = "0x50D6C0", Length = "0x8A")]
	[Token(Token = "0x600005E")]
	public void ForceUpdateSkAnim(bool lateUpdate = false)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x50F290", Offset = "0x50DA90", Length = "0xA94")]
	public void Init(int idx, int curScene)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x50F160", Offset = "0x50D960", Length = "0x127")]
	private void InitSkField(SkeletonAnimation ska)
	{
	}

	[Address(RVA = "0x50E9F0", Offset = "0x50D1F0", Length = "0x1FF")]
	[Token(Token = "0x6000061")]
	private void DoctorSkInit(SkeletonAnimation ska)
	{
	}

	[Address(RVA = "0x510350", Offset = "0x50EB50", Length = "0x190")]
	[Token(Token = "0x6000062")]
	private void MikuSkInit(SkeletonAnimation ska)
	{
	}

	[Address(RVA = "0x50FD50", Offset = "0x50E550", Length = "0x5F6")]
	[Token(Token = "0x6000063")]
	private void JkSkillInit()
	{
	}

	[Address(RVA = "0x50E3F0", Offset = "0x50CBF0", Length = "0x2EA")]
	[Token(Token = "0x6000064")]
	public void CryptonSceneInit(SkeletonAnimation sk)
	{
	}

	[Address(RVA = "0x50FD40", Offset = "0x50E540", Length = "0x8")]
	[Token(Token = "0x6000065")]
	public bool IsLongPressDestroy()
	{
		return default(bool);
	}

	[Address(RVA = "0x50FD30", Offset = "0x50E530", Length = "0x8")]
	[Token(Token = "0x6000066")]
	public bool IsLongPressAlpha()
	{
		return default(bool);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x510BC0", Offset = "0x50F3C0", Length = "0x262")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x513380", Offset = "0x511B80", Length = "0x1F7")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x511F50", Offset = "0x510750", Length = "0x1EF")]
	public void PlayDestroyEffect()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x50E0B0", Offset = "0x50C8B0", Length = "0x33F")]
	public void Clip(float percent, uint result)
	{
	}

	[Address(RVA = "0x514390", Offset = "0x512B90", Length = "0xC2")]
	[Token(Token = "0x600006B")]
	public void StopStar()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x513580", Offset = "0x511D80", Length = "0x340")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x50E920", Offset = "0x50D120", Length = "0xCB")]
	public void DestroyLongPress()
	{
	}

	[Address(RVA = "0x512140", Offset = "0x510940", Length = "0x1C4")]
	[Token(Token = "0x600006E")]
	public static void PlayLongPressEffect(bool isTo, bool isAir = false)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x513990", Offset = "0x512190", Length = "0x776")]
	public void SetLength(decimal time)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x5104F0", Offset = "0x50ECF0", Length = "0x485")]
	public void OnControllerStart()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x50E020", Offset = "0x50C820", Length = "0x87")]
	private void ClearTracks()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x5110C0", Offset = "0x50F8C0", Length = "0x2FB")]
	public static void PlayAnimator(string actionKey, int idx, int layer = 0, float tick = 0f, bool isOverride = true)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x5113C0", Offset = "0x50FBC0", Length = "0x279")]
	private static void PlayAnimator(string actionKey, GameObject obj, Animator animator = null)
	{
	}

	[Address(RVA = "0x512C00", Offset = "0x511400", Length = "0x3D8")]
	[Token(Token = "0x6000074")]
	public static void Play(string actionKey, GameObject obj, float tick = 0f, SpineActionController sac = null, Animator animator = null, bool isOverride = true)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x50E6E0", Offset = "0x50CEE0", Length = "0x12A")]
	public static void CustomPlay(string actionKey, GameObject obj, SpineActionController sac, Animator animator = null, float tick = 0f, bool isOverride = true, Action complete = null, bool allowAnimator = true)
	{
	}

	[Address(RVA = "0x50E810", Offset = "0x50D010", Length = "0x108")]
	[Token(Token = "0x6000076")]
	private static void CustomPlay(string actionKey, GameObject obj, SpineActionController sac, float tick, bool isOverride, Action complete)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x512630", Offset = "0x510E30", Length = "0x222")]
	public static void PlaySkeletonAnim(string actionKey, int idx, bool isLoop = false, bool isOverride = true, float delay = 0f, float time = -1f)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x512860", Offset = "0x511060", Length = "0xEE")]
	public static void PlaySkeleton(string actionKey, int idx)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x512FE0", Offset = "0x5117E0", Length = "0x34A")]
	public static void Play(string actionKey, int idx, float tick = 0f, bool isOverride = true)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x50DCF0", Offset = "0x50C4F0", Length = "0xCE")]
	private TrackEntry AddAnimation(string n, bool isLoop, float delay)
	{
		return null;
	}

	[Address(RVA = "0x5138C0", Offset = "0x5120C0", Length = "0xC9")]
	[Token(Token = "0x600007D")]
	public TrackEntry SetAnimation(string n, bool isLoop)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x511ED0", Offset = "0x5106D0", Length = "0x7E")]
	public void PlayByKey(string actionKey, bool isOverride = true)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x511E30", Offset = "0x510630", Length = "0x96")]
	public void PlayByKeyWithCustomEvent(string actionKey, Action complete, bool isOverride = true)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x514460", Offset = "0x512C60", Length = "0x245")]
	private bool TryGetSkeletActionData(string actionKey, out SkeletActionData result)
	{
		System.Runtime.CompilerServices.Unsafe.As<SkeletActionData, @null>(ref result) = null;
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x511990", Offset = "0x510190", Length = "0x49D")]
	private void PlayByData(SkeletActionData data, bool isOverride = true)
	{
	}

	[Address(RVA = "0x511640", Offset = "0x50FE40", Length = "0x34B")]
	[Token(Token = "0x6000082")]
	private void PlayByDataWithCustomEvent(SkeletActionData data, Action complete, bool isOverride = true)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x514110", Offset = "0x512910", Length = "0x277")]
	private void SetSyncObjects(List<GameObject> syncObjs)
	{
	}

	[Address(RVA = "0x50DF70", Offset = "0x50C770", Length = "0xAD")]
	[Token(Token = "0x6000089")]
	private bool CheckActionProtect(SkeletActionData data)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x510A70", Offset = "0x50F270", Length = "0x147")]
	private void OnNoteDisappear(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x50EBF0", Offset = "0x50D3F0", Length = "0x2C1")]
	[Token(Token = "0x600008B")]
	public void FixSpineAnim()
	{
	}

	[Address(RVA = "0x512950", Offset = "0x511150", Length = "0x26F")]
	[Token(Token = "0x600008C")]
	public static void Play(SacPlaySetting setting, float tick = 0f, bool isOverride = true)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x512BC0", Offset = "0x5113C0", Length = "0x38")]
	public static void Play(SacPlaySetting setting, SpineActionController sac, float tick = 0f, bool isOverride = true)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x50EF50", Offset = "0x50D750", Length = "0x1E")]
	public static SacPlaySetting GetDefaultSpinePlayerSetting()
	{
		return default(SacPlaySetting);
	}

	[Address(RVA = "0x510E30", Offset = "0x50F630", Length = "0x28E")]
	[Token(Token = "0x600008F")]
	private static void PlayAnimations(SacPlaySetting setting, SpineActionController sac, float tick, bool isOverride)
	{
	}

	[Address(RVA = "0x50EF70", Offset = "0x50D770", Length = "0xBF")]
	[Token(Token = "0x6000090")]
	private static SpineActionController GetSacByIdx(int index)
	{
		return null;
	}

	[Address(RVA = "0x512310", Offset = "0x510B10", Length = "0x315")]
	[Token(Token = "0x6000091")]
	private void PlaySkeletonAction(SacPlaySetting setting, bool isOverride)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x514840", Offset = "0x513040", Length = "0x7D")]
	public SpineActionController()
	{
	}
}
