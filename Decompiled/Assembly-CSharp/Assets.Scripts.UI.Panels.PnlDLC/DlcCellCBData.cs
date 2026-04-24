using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000935")]
public class DlcCellCBData : IPnlDlcCellData, IEquatable<IPnlDlcCellData>
{
	[Token(Token = "0x4003189")]
	[FieldOffset(Offset = "0x18")]
	private string m_SelectUid;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400318A")]
	public CollectionBundle cbConfigData;

	[Token(Token = "0x170008CA")]
	public int cellIndex
	{
		[CompilerGenerated]
		[Token(Token = "0x600533F")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		[Token(Token = "0x6005340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008CB")]
	public string selectUid
	{
		[Token(Token = "0x6005341")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005342")]
		[Address(RVA = "0x42CF50", Offset = "0x42B750", Length = "0x6B")]
		set
		{
		}
	}

	[Token(Token = "0x6005343")]
	[Address(RVA = "0x42CEB0", Offset = "0x42B6B0", Length = "0x89")]
	public DlcCellCBData(CollectionBundle collectionBundle, string tempSelectUid)
	{
	}

	[Address(RVA = "0x42CB60", Offset = "0x42B360", Length = "0x8D")]
	[Token(Token = "0x6005344")]
	public bool Equals(IPnlDlcCellData other)
	{
		return default(bool);
	}

	[Address(RVA = "0x42CD40", Offset = "0x42B540", Length = "0xB2")]
	[Token(Token = "0x6005345")]
	public string GetRandomPackageUid()
	{
		return null;
	}

	[Token(Token = "0x6005346")]
	[Address(RVA = "0x42CE00", Offset = "0x42B600", Length = "0xA2")]
	public bool IsContainsTargetAlbumJsonIndex(int albumJsonIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6005347")]
	[Address(RVA = "0x42CBF0", Offset = "0x42B3F0", Length = "0x97")]
	public int GetFirstAlbumJsonIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6005348")]
	[Address(RVA = "0x42CC90", Offset = "0x42B490", Length = "0xA2")]
	public LocalCollectionBundle GetLocalBundle()
	{
		return null;
	}
}
