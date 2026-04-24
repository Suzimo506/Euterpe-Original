using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;

namespace Assets.Scripts.Database;

[Token(Token = "0x200080C")]
public class DBOther : BaseDatabase
{
	[Token(Token = "0x2000D08")]
	public enum FxType
	{
		[Token(Token = "0x4003E9F")]
		Dust,
		[Token(Token = "0x4003EA0")]
		Music,
		[Token(Token = "0x4003EA1")]
		Hp
	}

	[Token(Token = "0x40029E8")]
	[FieldOffset(Offset = "0x10")]
	private float m_KeyAudioVolume;

	[Token(Token = "0x40029E9")]
	[FieldOffset(Offset = "0x14")]
	private float m_VoiceAudioVolume;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40029EA")]
	private string m_DustFx;

	[Token(Token = "0x40029EB")]
	[FieldOffset(Offset = "0x20")]
	private string m_MusicFx;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40029EC")]
	private string m_HpFx;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40029ED")]
	private DBConfigAlbums m_DBConfigAlbums;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40029EE")]
	private AgeRange m_AgeRange;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40029EF")]
	public bool screenEffectEnable;

	[Token(Token = "0x40029F0")]
	[FieldOffset(Offset = "0x3D")]
	public bool isAudioVisPlay;

	[Token(Token = "0x40029F1")]
	[FieldOffset(Offset = "0x3E")]
	public bool haveRealNameVerify;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40029F2")]
	private string m_CurSelectSongAlbum;

	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40029F4")]
	public bool isNewPlayer;

	[Token(Token = "0x17000752")]
	public float KeyAudioVolume
	{
		[Token(Token = "0x60048D0")]
		[Address(RVA = "0x98E3D0", Offset = "0x98CBD0", Length = "0x6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000753")]
	public float VoiceAudioVolume
	{
		[Token(Token = "0x60048D1")]
		[Address(RVA = "0x474E90", Offset = "0x473690", Length = "0x6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000754")]
	public bool isGCScene
	{
		[Address(RVA = "0x102D500", Offset = "0x102BD00", Length = "0xAB")]
		[Token(Token = "0x60048D2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000755")]
	public bool isDjMaxScene
	{
		[Address(RVA = "0x102D450", Offset = "0x102BC50", Length = "0xAB")]
		[Token(Token = "0x60048D3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000756")]
	public bool IsArkNightSong
	{
		[CompilerGenerated]
		[Token(Token = "0x60048D4")]
		[Address(RVA = "0x5B0970", Offset = "0x5AF170", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x60048D5")]
		[Address(RVA = "0x566160", Offset = "0x564960", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000757")]
	public AgeRange ageRange
	{
		[Token(Token = "0x60048DB")]
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		get
		{
			return default(AgeRange);
		}
		[Token(Token = "0x60048DC")]
		[Address(RVA = "0x597050", Offset = "0x595850", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000758")]
	public bool isAdult
	{
		[Token(Token = "0x60048DD")]
		[Address(RVA = "0x102D440", Offset = "0x102BC40", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000759")]
	public bool isRegressionPlayer
	{
		[Token(Token = "0x60048DE")]
		[Address(RVA = "0x102D5B0", Offset = "0x102BDB0", Length = "0x238")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60048D6")]
	[Address(RVA = "0x102D110", Offset = "0x102B910", Length = "0x1A2")]
	public void CheckIsArkNightSong()
	{
	}

	[Address(RVA = "0x102D370", Offset = "0x102BB70", Length = "0x3C")]
	[Token(Token = "0x60048D7")]
	public void SetFxName(FxType fxType, string str)
	{
	}

	[Address(RVA = "0x102D2C0", Offset = "0x102BAC0", Length = "0x20")]
	[Token(Token = "0x60048D8")]
	public string GetFxName(FxType fxType)
	{
		return null;
	}

	[Address(RVA = "0x102CF10", Offset = "0x102B710", Length = "0x1FD")]
	[Token(Token = "0x60048D9")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60048DA")]
	[Address(RVA = "0x102D2E0", Offset = "0x102BAE0", Length = "0x84")]
	public override void Release()
	{
	}

	[Token(Token = "0x60048DF")]
	[Address(RVA = "0x102D3B0", Offset = "0x102BBB0", Length = "0x8A")]
	public DBOther()
	{
	}
}
