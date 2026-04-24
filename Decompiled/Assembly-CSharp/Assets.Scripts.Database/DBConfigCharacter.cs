using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A2")]
public class DBConfigCharacter : BaseDBConfigLocalObject<DBConfigLocalCharacter, LocalCharacterInfo>
{
	[Token(Token = "0x4002884")]
	[FieldOffset(Offset = "0x40")]
	private List<CharacterInfo> m_Items;

	[Token(Token = "0x170006C5")]
	protected List<CharacterInfo> list
	{
		[Token(Token = "0x60046F2")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60046F3")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x170006C6")]
	public int freeCount
	{
		[Address(RVA = "0x6F6FB0", Offset = "0x6F57B0", Length = "0x104")]
		[Token(Token = "0x60046FF")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006C7")]
	public int noHideCount
	{
		[Address(RVA = "0x6F70C0", Offset = "0x6F58C0", Length = "0xFB")]
		[Token(Token = "0x6004700")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60046F4")]
	[Address(RVA = "0x6F6F30", Offset = "0x6F5730", Length = "0x7F")]
	public DBConfigCharacter()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x60046F5")]
	[Address(RVA = "0x6F66D0", Offset = "0x6F4ED0", Length = "0x178")]
	public CharacterInfo FindCharacterInfo(Func<CharacterInfo, bool> func)
	{
		return null;
	}

	[Token(Token = "0x60046F6")]
	[Address(RVA = "0x6F68C0", Offset = "0x6F50C0", Length = "0x172")]
	public CharacterInfo GetCharacterInfoByMainShow(string mainShow)
	{
		return null;
	}

	[Token(Token = "0x60046F7")]
	[Address(RVA = "0x6F65C0", Offset = "0x6F4DC0", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}

	[Token(Token = "0x60046F8")]
	[Address(RVA = "0x6F6A40", Offset = "0x6F5240", Length = "0x167")]
	public CharacterInfo GetCharacterInfoByOrder(int order)
	{
		return null;
	}

	[Token(Token = "0x60046F9")]
	[Address(RVA = "0x6F6850", Offset = "0x6F5050", Length = "0x6B")]
	public CharacterInfo GetCharacterInfoByIndex(int index)
	{
		return null;
	}

	[Address(RVA = "0x6F6CD0", Offset = "0x6F54D0", Length = "0x252")]
	[Token(Token = "0x60046FA")]
	public List<int> GetLockedItemIndexList(List<int> unlockItemIdxs)
	{
		return null;
	}

	[Token(Token = "0x60046FB")]
	[Address(RVA = "0x6F6410", Offset = "0x6F4C10", Length = "0x36")]
	private bool CheckInfoForLockItem(CharacterInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60046FC")]
	[Address(RVA = "0x6F6450", Offset = "0x6F4C50", Length = "0x16D")]
	public int CompareInfoByIndex(int index1, int index2)
	{
		return default(int);
	}

	[Token(Token = "0x60046FD")]
	[Address(RVA = "0x6F63B0", Offset = "0x6F4BB0", Length = "0x52")]
	public List<CharacterInfo> CharactersFilter(Predicate<CharacterInfo> condition)
	{
		return null;
	}

	[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
	[Token(Token = "0x60046FE")]
	public List<CharacterInfo> GetAllDatas()
	{
		return null;
	}

	[Address(RVA = "0x6F6BB0", Offset = "0x6F53B0", Length = "0x11C")]
	[Token(Token = "0x6004701")]
	public int GetFreeCountByRarity(string rarity)
	{
		return default(int);
	}
}
