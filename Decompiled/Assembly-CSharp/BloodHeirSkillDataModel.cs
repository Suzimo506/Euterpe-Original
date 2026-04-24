using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

[Token(Token = "0x200001E")]
public class BloodHeirSkillDataModel : DataModel
{
	[Token(Token = "0x400008B")]
	public const string sfx_special_hp_recover = "sfx_hp";

	[Token(Token = "0x400008C")]
	public const string pref_note_sp_hp = "hp_on_note_bloodheir";

	[Token(Token = "0x400008D")]
	public const string vfx_role_skill_on = "char_2_bloodheir_big_particle";

	[Token(Token = "0x400008E")]
	public const string spi_role_skill_on_shadow = "bloodheir_girl_skill_on_shadow";

	[Token(Token = "0x400008F")]
	public const string spi_hud_hp_fire_sign = "hud_spi_fire_bloodheir";

	[Token(Token = "0x4000090")]
	private const string touhou_prefix = "_touhou_black";

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x178")]
	private GameObject m_PrefSpHpBlood;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x180")]
	private GameObject m_PrefRoleSkillVfx;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000096")]
	private GameObject m_SpiRoleSkillOnShadow;

	[Token(Token = "0x17000017")]
	public bool IsInBloodHeirShow
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x60000C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public bool IsInBloodHeirState
	{
		[Address(RVA = "0x45CA60", Offset = "0x45B260", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000C2")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C3")]
		[CompilerGenerated]
		[Address(RVA = "0x45C990", Offset = "0x45B190", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public MusicData CreatedBloodMusicData
	{
		[CompilerGenerated]
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x45C9A0", Offset = "0x45B1A0", Length = "0xA3")]
		get
		{
			return default(MusicData);
		}
		[CompilerGenerated]
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x45CE90", Offset = "0x45B690", Length = "0x9C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public GameObject PrefSpHpBlood
	{
		[Address(RVA = "0x45CBD0", Offset = "0x45B3D0", Length = "0x159")]
		[Token(Token = "0x60000C6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001B")]
	public GameObject PrefRoleSkillVfxObj
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x45CA70", Offset = "0x45B270", Length = "0x159")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public GameObject SpiRoleSkillOnShadow
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x45CD30", Offset = "0x45B530", Length = "0x159")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x45C990", Offset = "0x45B190", Length = "0x4")]
	[Token(Token = "0x60000C9")]
	public void SetBloodHeirState(bool isInVampireState)
	{
	}

	[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
	[Token(Token = "0x60000CA")]
	public void SetBloodHeirShow(bool isBig)
	{
	}

	[Address(RVA = "0x45C580", Offset = "0x45AD80", Length = "0x1F8")]
	[Token(Token = "0x60000CB")]
	public bool IsSpecialBloodNote(MusicData md)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x45C780", Offset = "0x45AF80", Length = "0x1FA")]
	public override void Release()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60000CD")]
	public BloodHeirSkillDataModel()
	{
	}
}
