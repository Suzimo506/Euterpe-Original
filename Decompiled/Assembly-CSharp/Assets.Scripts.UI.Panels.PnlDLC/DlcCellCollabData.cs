using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000936")]
public class DlcCellCollabData : IPnlDlcCellData, IEquatable<IPnlDlcCellData>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400318C")]
	private string m_SelectUid;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400318D")]
	private int m_IPIndex;

	[Token(Token = "0x400318E")]
	[FieldOffset(Offset = "0x24")]
	private int m_PackageIndexInIP;

	[Token(Token = "0x170008CC")]
	public int cellIndex
	{
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		[Token(Token = "0x6005349")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		[Token(Token = "0x600534A")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008CD")]
	public string selectUid
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x600534B")]
		get
		{
			return null;
		}
		[Address(RVA = "0x42CF50", Offset = "0x42B750", Length = "0x6B")]
		[Token(Token = "0x600534C")]
		set
		{
		}
	}

	[Token(Token = "0x170008CE")]
	public int ipIndex
	{
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		[Token(Token = "0x600534D")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600534E")]
		[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170008CF")]
	public int packageIndexInIP
	{
		[Address(RVA = "0x42D1F0", Offset = "0x42B9F0", Length = "0x4")]
		[Token(Token = "0x600534F")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005350")]
		[Address(RVA = "0x42D210", Offset = "0x42BA10", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x6005351")]
	[Address(RVA = "0x42D100", Offset = "0x42B900", Length = "0xD2")]
	public int GetFirstAlbumJsonIndexInFirstIP()
	{
		return default(int);
	}

	[Token(Token = "0x6005352")]
	[Address(RVA = "0x42D050", Offset = "0x42B850", Length = "0xAF")]
	public string GetAlbumUidForCollectionBundle()
	{
		return null;
	}

	[Token(Token = "0x6005353")]
	[Address(RVA = "0x42CFC0", Offset = "0x42B7C0", Length = "0x84")]
	public bool Equals(IPnlDlcCellData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005354")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DlcCellCollabData()
	{
	}
}
