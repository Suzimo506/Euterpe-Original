using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs.Modules;

[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
[Token(Token = "0x2000597")]
public class MusicInfoResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40020DB")]
	private List<MusicInfo> m_Lock;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40020DC")]
	private List<MusicInfo> m_Unlock;

	[Token(Token = "0x1700052D")]
	public List<MusicInfo> lockInfos
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60038B5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052E")]
	public List<MusicInfo> unlockInfos
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x60038B6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052F")]
	public int count
	{
		[Address(RVA = "0x657250", Offset = "0x655A50", Length = "0x47")]
		[Token(Token = "0x60038B9")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000530")]
	public MusicInfo Item
	{
		[Token(Token = "0x60038BC")]
		[Address(RVA = "0x6571B0", Offset = "0x6559B0", Length = "0x9A")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x656F40", Offset = "0x655740", Length = "0x71")]
	[Token(Token = "0x60038B7")]
	public void Add(MusicInfo info, bool isUnlock)
	{
	}

	[Token(Token = "0x60038B8")]
	[Address(RVA = "0x656FC0", Offset = "0x6557C0", Length = "0x58")]
	public void Clear()
	{
	}

	[Token(Token = "0x60038BA")]
	[Address(RVA = "0x657090", Offset = "0x655890", Length = "0x71")]
	public void Merge(MusicInfoResult result)
	{
	}

	[Token(Token = "0x60038BB")]
	[Address(RVA = "0x657020", Offset = "0x655820", Length = "0x6F")]
	public void Filter()
	{
	}

	[Token(Token = "0x60038BD")]
	[Address(RVA = "0x657110", Offset = "0x655910", Length = "0x96")]
	public MusicInfoResult()
	{
	}
}
