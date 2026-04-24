using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

[Token(Token = "0x2000021")]
public class DiverSkillDataModel : DataModel
{
	[Token(Token = "0x1700001D")]
	public MusicData CreatedDaveFishMusicData
	{
		[Address(RVA = "0x441AF0", Offset = "0x4402F0", Length = "0xA3")]
		[Token(Token = "0x60000D7")]
		[CompilerGenerated]
		get
		{
			return default(MusicData);
		}
		[Address(RVA = "0x441BA0", Offset = "0x4403A0", Length = "0x9C")]
		[CompilerGenerated]
		[Token(Token = "0x60000D8")]
		set
		{
		}
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x4418E0", Offset = "0x4400E0", Length = "0x1F8")]
	public bool IsSpecialDaveFishNote(MusicData md)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x441840", Offset = "0x440040", Length = "0x98")]
	public GameObject GetDaveFishPref(DaveFishQuality quality)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public DiverSkillDataModel()
	{
	}
}
