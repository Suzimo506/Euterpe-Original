using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

[Token(Token = "0x2000772")]
public class WisadelGameEffectController
{
	[Token(Token = "0x4002769")]
	public const string vfx_skill = "W_fx_skill";

	[Token(Token = "0x400276A")]
	private const string vfx_perfect_hit = "W_fx_Perfect4";

	[Token(Token = "0x400276B")]
	private const string vfx_jump = "W_fx_jump";

	[Token(Token = "0x400276C")]
	private const string vfx_dead = "W_fx_road_die";

	[Token(Token = "0x400276D")]
	private const string vfx_monster_vertigo = "fx_note_monster_fever_vertigo";

	[Token(Token = "0x400276E")]
	private const string vfx_w_effect_bomb = "vfx_w_effect_bomb";

	[Token(Token = "0x400276F")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_VfxMonsterVertigo;

	[Token(Token = "0x4002770")]
	[FieldOffset(Offset = "0x18")]
	private Effect m_PerfectHitVfx;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002771")]
	private Effect m_JumpVfx;

	[Token(Token = "0x4002772")]
	[FieldOffset(Offset = "0x28")]
	private Effect m_DeadVfx;

	[Token(Token = "0x1700068F")]
	public GameObject VfxMonsterVertigo
	{
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60045C6")]
	[Address(RVA = "0x4AD630", Offset = "0x4ABE30", Length = "0x25C")]
	public void InitEffects()
	{
	}

	[Token(Token = "0x60045C7")]
	[Address(RVA = "0x4AD4A0", Offset = "0x4ABCA0", Length = "0x18F")]
	public bool CreateSpecialFeverInstance()
	{
		return default(bool);
	}

	[Token(Token = "0x60045C8")]
	[Address(RVA = "0x4AD960", Offset = "0x4AC160", Length = "0x195")]
	public bool PlayPerfectHitEffect(bool isAir)
	{
		return default(bool);
	}

	[Token(Token = "0x60045C9")]
	[Address(RVA = "0x4AD8F0", Offset = "0x4AC0F0", Length = "0x60")]
	public bool PlayJumpEffect()
	{
		return default(bool);
	}

	[Address(RVA = "0x4AD890", Offset = "0x4AC090", Length = "0x5B")]
	[Token(Token = "0x60045CA")]
	public void PlayDeadEffect()
	{
	}

	[Token(Token = "0x60045CB")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public WisadelGameEffectController()
	{
	}
}
