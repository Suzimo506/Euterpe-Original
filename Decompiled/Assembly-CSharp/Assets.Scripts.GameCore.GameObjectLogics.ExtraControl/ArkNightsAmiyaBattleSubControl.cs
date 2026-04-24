using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

[Token(Token = "0x200076A")]
public class ArkNightsAmiyaBattleSubControl : RoleBattleSubControl, IPause
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002750")]
	[SerializeField]
	private ParticleSystem[] m_FeverInvokeParticles;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002751")]
	[SerializeField]
	private ParticleSystem[] m_FeverEndParticles;

	[Token(Token = "0x4002752")]
	[FieldOffset(Offset = "0x58")]
	private ParticleSystem m_FeverInvokeParticle;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002753")]
	private ParticleSystem m_FeverEndParticle;

	[Token(Token = "0x1700068D")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x600459B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004594")]
	[Address(RVA = "0x4966F0", Offset = "0x494EF0", Length = "0x41D")]
	public override void Init()
	{
	}

	[Token(Token = "0x6004595")]
	[Address(RVA = "0x496690", Offset = "0x494E90", Length = "0x57")]
	private void InitParticle()
	{
	}

	[Token(Token = "0x6004596")]
	[Address(RVA = "0x496B30", Offset = "0x495330", Length = "0x1D")]
	private void OnFeverInvoke()
	{
	}

	[Token(Token = "0x6004597")]
	[Address(RVA = "0x496B10", Offset = "0x495310", Length = "0x1D")]
	private void OnFeverEnd()
	{
	}

	[Token(Token = "0x6004598")]
	[Address(RVA = "0x496BC0", Offset = "0x4953C0", Length = "0x17A")]
	public override void Release(bool isEditor)
	{
	}

	[Token(Token = "0x6004599")]
	[Address(RVA = "0x496B50", Offset = "0x495350", Length = "0x61")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x496D40", Offset = "0x495540", Length = "0x61")]
	[Token(Token = "0x600459A")]
	public void Resume()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600459C")]
	public ArkNightsAmiyaBattleSubControl()
	{
	}
}
