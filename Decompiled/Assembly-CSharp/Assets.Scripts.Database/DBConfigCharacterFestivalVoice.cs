using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A7")]
public class DBConfigCharacterFestivalVoice : BaseDBConfigLocalObject<DBConfigLocalCharacterFestivalVoice, LocalCharacterFestivalVoiceInfo>
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400288F")]
	private List<CharacterFestivalVoiceInfo> m_Items;

	[Token(Token = "0x170006C9")]
	protected List<CharacterFestivalVoiceInfo> list
	{
		[Token(Token = "0x600470C")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600470D")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x600470E")]
	[Address(RVA = "0x6F6310", Offset = "0x6F4B10", Length = "0x9C")]
	public DBConfigCharacterFestivalVoice()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x600470F")]
	[Address(RVA = "0x6F6090", Offset = "0x6F4890", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x6004710")]
	[Address(RVA = "0x6F61A0", Offset = "0x6F49A0", Length = "0x164")]
	public CharacterFestivalVoiceInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
