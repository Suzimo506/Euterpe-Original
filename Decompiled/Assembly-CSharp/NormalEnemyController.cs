using Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000047")]
public class NormalEnemyController : BaseEnemyObjectController
{
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40001B3")]
	private ParticleSystem[] m_ParticleSystems;

	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40001B4")]
	private WisadelBossVertigoEffectComponent m_BossVertigoEffectController;

	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40001B5")]
	private bool m_IsBoss;

	[Token(Token = "0x1700003E")]
	public bool IsBoss
	{
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x81CF20", Offset = "0x81B720", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003F")]
	public WisadelBossVertigoEffectComponent BossVertigoEffectComponent
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x86D170", Offset = "0x86B970", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x86C870", Offset = "0x86B070", Length = "0x68")]
	[Token(Token = "0x6000200")]
	public override void OnControllerStart()
	{
	}

	[Address(RVA = "0x86C6B0", Offset = "0x86AEB0", Length = "0x1BE")]
	[Token(Token = "0x6000201")]
	public override bool OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x86C5E0", Offset = "0x86ADE0", Length = "0xCF")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Address(RVA = "0x86BFD0", Offset = "0x86A7D0", Length = "0x60B")]
	[Token(Token = "0x6000203")]
	public override void Init(int scene)
	{
	}

	[Address(RVA = "0x86CB20", Offset = "0x86B320", Length = "0x17D")]
	[Token(Token = "0x6000204")]
	public override void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x86CCA0", Offset = "0x86B4A0", Length = "0x174")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x86CE30", Offset = "0x86B630", Length = "0x2D3")]
	public override void SetVisible(bool enable)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x86CE20", Offset = "0x86B620", Length = "0x8")]
	public void SetBossMark()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x86CA00", Offset = "0x86B200", Length = "0x11F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x86C8E0", Offset = "0x86B0E0", Length = "0x11F")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x86BE90", Offset = "0x86A690", Length = "0x139")]
	private void CheckIsSpecialNote(int sceneCode)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x86D110", Offset = "0x86B910", Length = "0x51")]
	public NormalEnemyController()
	{
	}
}
