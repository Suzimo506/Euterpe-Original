using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

[Token(Token = "0x2000036")]
public class AirMusicNodeController : BaseEnemyObjectController
{
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000157")]
	protected GameObject m_Fx;

	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000158")]
	protected ParticleSystem[] m_ParticleSystems;

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x593450", Offset = "0x591C50", Length = "0x3F")]
	public override void SetVisible(bool enable)
	{
	}

	[Address(RVA = "0x594190", Offset = "0x592990", Length = "0x16B")]
	[Token(Token = "0x600013B")]
	public override void Init(int scene)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x593C20", Offset = "0x592420", Length = "0x56D")]
	public static void AddExtraScore(ref MusicData md, bool isAir)
	{
	}

	[Address(RVA = "0x594300", Offset = "0x592B00", Length = "0xA6")]
	[Token(Token = "0x600013D")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	[Token(Token = "0x600013E")]
	public override bool OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x5943B0", Offset = "0x592BB0", Length = "0xC7")]
	public override void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x594480", Offset = "0x592C80", Length = "0xBF")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x594540", Offset = "0x592D40", Length = "0x51")]
	public AirMusicNodeController()
	{
	}
}
