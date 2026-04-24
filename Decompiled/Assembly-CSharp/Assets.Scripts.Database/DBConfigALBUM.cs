using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200078B")]
public class DBConfigALBUM : BaseDBConfigLocalObject<DBConfigLocalALBUM, LocalALBUMInfo>
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40027EC")]
	private List<MusicInfo> m_Items;

	[Token(Token = "0x170006B5")]
	protected List<MusicInfo> list
	{
		[Token(Token = "0x600469D")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		[Token(Token = "0x600469E")]
		private set
		{
		}
	}

	[Token(Token = "0x600469C")]
	[Address(RVA = "0x6F42F0", Offset = "0x6F2AF0", Length = "0x9C")]
	public DBConfigALBUM()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x600469F")]
	[Address(RVA = "0x6F3F10", Offset = "0x6F2710", Length = "0x12B")]
	public void GetAllMusicUids(List<string> buffer, bool clear = false)
	{
	}

	[Token(Token = "0x60046A0")]
	[Address(RVA = "0x6F3E10", Offset = "0x6F2610", Length = "0xFC")]
	public void GetAllMusicInfo(List<MusicInfo> buffer)
	{
	}

	[Token(Token = "0x60046A1")]
	[Address(RVA = "0x6F3CE0", Offset = "0x6F24E0", Length = "0x12B")]
	public void GetAllMusicInfo(Dictionary<string, MusicInfo> dic, bool clear = false)
	{
	}

	[Token(Token = "0x60046A2")]
	[Address(RVA = "0x6F4110", Offset = "0x6F2910", Length = "0x5A")]
	public MusicInfo GetMusicInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60046A3")]
	[Address(RVA = "0x6F4170", Offset = "0x6F2970", Length = "0x172")]
	public MusicInfo GetMusicInfoByMusicUid(string uid)
	{
		return null;
	}

	[Address(RVA = "0x6F4040", Offset = "0x6F2840", Length = "0xC7")]
	[Token(Token = "0x60046A4")]
	public int GetIndexByUid(string uid)
	{
		return default(int);
	}

	[Address(RVA = "0x6F3BD0", Offset = "0x6F23D0", Length = "0x100")]
	[Token(Token = "0x60046A5")]
	public override void Deserialize(string str)
	{
	}
}
