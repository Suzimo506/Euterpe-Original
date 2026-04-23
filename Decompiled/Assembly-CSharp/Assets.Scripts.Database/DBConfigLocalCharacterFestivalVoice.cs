using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A6")]
public class DBConfigLocalCharacterFestivalVoice : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400288E")]
	private List<LocalCharacterFestivalVoiceInfo> m_Items;

	[Token(Token = "0x170006C8")]
	protected List<LocalCharacterFestivalVoiceInfo> list
	{
		[Token(Token = "0x6004708")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004709")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x6004707")]
	[Address(RVA = "0x6FBCC0", Offset = "0x6FA4C0", Length = "0x7A")]
	public DBConfigLocalCharacterFestivalVoice()
	{
	}

	[Address(RVA = "0x6FBC50", Offset = "0x6FA450", Length = "0x6B")]
	[Token(Token = "0x600470A")]
	public LocalCharacterFestivalVoiceInfo GetInfoByListIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600470B")]
	[Address(RVA = "0x6FBB40", Offset = "0x6FA340", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}
