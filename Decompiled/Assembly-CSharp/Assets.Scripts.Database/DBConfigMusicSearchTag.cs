using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007E2")]
public class DBConfigMusicSearchTag : BaseDBConfigObject
{
	[Token(Token = "0x400295E")]
	[FieldOffset(Offset = "0x38")]
	private List<MusicSearchTagInfo> m_Items;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400295F")]
	private Dictionary<string, MusicSearchTagInfo> m_Dictionary;

	[Token(Token = "0x1700071D")]
	protected List<MusicSearchTagInfo> list
	{
		[Token(Token = "0x600480A")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600480B")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x600480C")]
	[Address(RVA = "0x6FE120", Offset = "0x6FC920", Length = "0xA7")]
	public DBConfigMusicSearchTag()
	{
	}

	[Token(Token = "0x600480D")]
	[Address(RVA = "0x6FE0B0", Offset = "0x6FC8B0", Length = "0x62")]
	public bool TryGetInfo(string musicUid, out MusicSearchTagInfo info)
	{
		info = null;
		return default(bool);
	}

	[Token(Token = "0x600480E")]
	[Address(RVA = "0x6FDEE0", Offset = "0x6FC6E0", Length = "0x1CD")]
	public override void Deserialize(string str)
	{
	}
}
