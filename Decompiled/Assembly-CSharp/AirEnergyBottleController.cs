using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

[Token(Token = "0x2000034")]
public class AirEnergyBottleController : BaseEnemyObjectController
{
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x218")]
	protected GameObject m_Fx;

	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000155")]
	protected ParticleSystem[] m_ParticleSystems;

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x593490", Offset = "0x591C90", Length = "0x4A9")]
	public static void TouhouAddRedPoint(ref MusicData md, bool girlIsAir)
	{
	}

	[Address(RVA = "0x593450", Offset = "0x591C50", Length = "0x3F")]
	[Token(Token = "0x600012F")]
	public override void SetVisible(bool enable)
	{
	}

	[Address(RVA = "0x5923F0", Offset = "0x590BF0", Length = "0x16B")]
	[Token(Token = "0x6000130")]
	public override void Init(int scene)
	{
	}

	[Address(RVA = "0x592710", Offset = "0x590F10", Length = "0xC75")]
	[Token(Token = "0x6000131")]
	public static void RecoveryEffects(ref MusicData md, bool fxIsAir)
	{
	}

	[Address(RVA = "0x592560", Offset = "0x590D60", Length = "0xD2")]
	[Token(Token = "0x6000132")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	public override bool OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x592640", Offset = "0x590E40", Length = "0xC7")]
	public override void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x593390", Offset = "0x591B90", Length = "0xBF")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x593940", Offset = "0x592140", Length = "0x51")]
	public AirEnergyBottleController()
	{
	}
}
