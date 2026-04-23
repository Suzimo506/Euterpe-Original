using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using GameLogic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000760")]
public class AttackEffectManager : SerializedMonoBehaviour, IPause, IRelease
{
	[Token(Token = "0x4002702")]
	[FieldOffset(Offset = "0x58")]
	public bool hideAtkFx;

	[Token(Token = "0x4002703")]
	[FieldOffset(Offset = "0x60")]
	public GameObject zombieSkill;

	[Token(Token = "0x4002704")]
	public const int COMBO_CHANGE_LIM = 20;

	[Token(Token = "0x4002705")]
	[FieldOffset(Offset = "0x68")]
	private Effect[] m_Effects;

	[Token(Token = "0x4002706")]
	[FieldOffset(Offset = "0x70")]
	private float[] playResultOffset;

	[Token(Token = "0x4002707")]
	[FieldOffset(Offset = "0x78")]
	private List<ParticleSystem> m_ParticleSystemList;

	[Token(Token = "0x4002708")]
	[FieldOffset(Offset = "0x80")]
	private ParticleSystem[] m_ParticleLongPress;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002709")]
	private List<Behaviour> m_PauseComponents;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4002714")]
	private Effect m_ElfinEffect;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4002715")]
	private Effect m_RoleEffect;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002716")]
	private GameObject m_PlayResult;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4002717")]
	private MusicData m_Playmd;

	[Token(Token = "0x4002718")]
	[FieldOffset(Offset = "0x258")]
	private bool m_PlayIsAir;

	[Token(Token = "0x4002719")]
	[FieldOffset(Offset = "0x259")]
	private bool m_PlayIsBossNearAtk;

	[Token(Token = "0x400271A")]
	[FieldOffset(Offset = "0x260")]
	public SpriteRenderer sprGameSceneHide;

	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400271B")]
	public List<AttackEffects> effects;

	[Token(Token = "0x1700067F")]
	public static AttackEffectManager instance
	{
		[CompilerGenerated]
		[Address(RVA = "0x49A810", Offset = "0x499010", Length = "0x75")]
		[Token(Token = "0x6004536")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x49A900", Offset = "0x499100", Length = "0x42")]
		private set
		{
		}
	}

	[Token(Token = "0x17000680")]
	public GameObject elfinRecoveryEffect
	{
		[CompilerGenerated]
		[Token(Token = "0x6004538")]
		[Address(RVA = "0x46D010", Offset = "0x46B810", Length = "0x8")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004537")]
		[Address(RVA = "0x49A8F0", Offset = "0x4990F0", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x17000681")]
	public GameObject roleRecoveryEffect
	{
		[Address(RVA = "0x49A8B0", Offset = "0x4990B0", Length = "0x8")]
		[Token(Token = "0x600453A")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x49A990", Offset = "0x499190", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x6004539")]
		private set
		{
		}
	}

	[Token(Token = "0x17000682")]
	public GameObject jokerSkillEffect
	{
		[CompilerGenerated]
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x48E690", Offset = "0x48CE90", Length = "0x8")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x49A960", Offset = "0x499160", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x17000683")]
	public GameObject jokerEndSkillEffect
	{
		[Token(Token = "0x600453E")]
		[Address(RVA = "0x460250", Offset = "0x45EA50", Length = "0x8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x49A950", Offset = "0x499150", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x600453D")]
		private set
		{
		}
	}

	[Token(Token = "0x17000684")]
	public GameObject zombieSkillEffect
	{
		[CompilerGenerated]
		[Address(RVA = "0x49A8E0", Offset = "0x4990E0", Length = "0x8")]
		[Token(Token = "0x6004540")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x600453F")]
		[Address(RVA = "0x49A9D0", Offset = "0x4991D0", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x17000685")]
	public GameObject nekoSkillEffect
	{
		[Token(Token = "0x6004542")]
		[Address(RVA = "0x49A890", Offset = "0x499090", Length = "0x8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x49A970", Offset = "0x499170", Length = "0xF")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000686")]
	public GameObject switchRockEffect
	{
		[Token(Token = "0x6004544")]
		[Address(RVA = "0x49A8D0", Offset = "0x4990D0", Length = "0x8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004543")]
		[Address(RVA = "0x49A9B0", Offset = "0x4991B0", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x17000687")]
	public GameObject switchSleepEffect
	{
		[Address(RVA = "0x460220", Offset = "0x45EA20", Length = "0x8")]
		[Token(Token = "0x6004546")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x49A9C0", Offset = "0x4991C0", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x6004545")]
		private set
		{
		}
	}

	[Token(Token = "0x17000688")]
	public GameObject sleepSkillEffect
	{
		[CompilerGenerated]
		[Token(Token = "0x6004548")]
		[Address(RVA = "0x49A8C0", Offset = "0x4990C0", Length = "0x8")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004547")]
		[Address(RVA = "0x49A9A0", Offset = "0x4991A0", Length = "0xF")]
		private set
		{
		}
	}

	[Token(Token = "0x17000689")]
	public List<Effect> racerSkillEffect
	{
		[CompilerGenerated]
		[Token(Token = "0x600454A")]
		[Address(RVA = "0x49A8A0", Offset = "0x4990A0", Length = "0x8")]
		get
		{
			return null;
		}
		[Address(RVA = "0x49A980", Offset = "0x499180", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x6004549")]
		private set
		{
		}
	}

	[Token(Token = "0x1700068A")]
	public bool IsGlobal
	{
		[Token(Token = "0x600455D")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600454B")]
	[Address(RVA = "0x496DB0", Offset = "0x4955B0", Length = "0xC3")]
	private void Awake()
	{
	}

	[Address(RVA = "0x496E80", Offset = "0x495680", Length = "0x235")]
	[Token(Token = "0x600454C")]
	private void Clean()
	{
	}

	[Token(Token = "0x600454D")]
	[Address(RVA = "0x499DE0", Offset = "0x4985E0", Length = "0x45")]
	public static void ReleaseReferences()
	{
	}

	[Token(Token = "0x600454E")]
	[Address(RVA = "0x498C80", Offset = "0x497480", Length = "0x70")]
	public GameObject InvokeRoleEffect()
	{
		return null;
	}

	[Token(Token = "0x600454F")]
	[Address(RVA = "0x498BB0", Offset = "0x4973B0", Length = "0xCD")]
	public GameObject InvokeRacerRoleEffect(int idx)
	{
		return null;
	}

	[Token(Token = "0x6004550")]
	[Address(RVA = "0x498B40", Offset = "0x497340", Length = "0x70")]
	public GameObject InvokeElfinEffect()
	{
		return null;
	}

	[Token(Token = "0x6004551")]
	[Address(RVA = "0x4973C0", Offset = "0x495BC0", Length = "0x15F5")]
	public void InitAttackSkillFx()
	{
	}

	[Address(RVA = "0x498EF0", Offset = "0x4976F0", Length = "0x81")]
	[Token(Token = "0x6004552")]
	private void OnFail()
	{
	}

	[Address(RVA = "0x498CF0", Offset = "0x4974F0", Length = "0xBE")]
	[Token(Token = "0x6004553")]
	private void OnComboChanged(int combo)
	{
	}

	[Address(RVA = "0x498DB0", Offset = "0x4975B0", Length = "0x13F")]
	[Token(Token = "0x6004554")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4971B0", Offset = "0x4959B0", Length = "0x20C")]
	[Token(Token = "0x6004555")]
	private string GetFeverName()
	{
		return null;
	}

	[Token(Token = "0x6004556")]
	[Address(RVA = "0x49A1F0", Offset = "0x4989F0", Length = "0x61B")]
	public void SetEffectAndFeverByCharacter(int roleIndex)
	{
	}

	[Address(RVA = "0x4998F0", Offset = "0x4980F0", Length = "0x4EE")]
	[Token(Token = "0x6004557")]
	public void PlayAttackEffect(uint resultCode, int idx)
	{
	}

	[Address(RVA = "0x4989C0", Offset = "0x4971C0", Length = "0x17B")]
	[Token(Token = "0x6004558")]
	public void Init()
	{
	}

	[Token(Token = "0x6004559")]
	[Address(RVA = "0x499E30", Offset = "0x498630", Length = "0xEF")]
	public void Release(bool isEditor)
	{
	}

	[Token(Token = "0x600455A")]
	[Address(RVA = "0x4970C0", Offset = "0x4958C0", Length = "0xEA")]
	private void GetComps(List<ParticleSystem> particleBuffer, List<Behaviour> buffer, GameObject go)
	{
	}

	[Token(Token = "0x600455B")]
	[Address(RVA = "0x498F80", Offset = "0x497780", Length = "0x966")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x600455C")]
	[Address(RVA = "0x499F20", Offset = "0x498720", Length = "0x2CC")]
	public void Resume()
	{
	}

	[Token(Token = "0x600455E")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public AttackEffectManager()
	{
	}
}
