using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000934")]
public class DlcCellAlbumData : IPnlDlcCellData, IEquatable<IPnlDlcCellData>
{
	[Token(Token = "0x4003187")]
	[FieldOffset(Offset = "0x18")]
	public DBConfigAlbums.AlbumsInfo albumConfigData;

	[Token(Token = "0x170008C8")]
	public int cellIndex
	{
		[CompilerGenerated]
		[Token(Token = "0x600533A")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x600533B")]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170008C9")]
	public int albumJsonIndex
	{
		[Token(Token = "0x600533E")]
		[Address(RVA = "0x42CB20", Offset = "0x42B320", Length = "0x14")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600533C")]
	[Address(RVA = "0x42CAE0", Offset = "0x42B2E0", Length = "0x37")]
	public DlcCellAlbumData(DBConfigAlbums.AlbumsInfo albumInfo)
	{
	}

	[Token(Token = "0x600533D")]
	[Address(RVA = "0x42CA50", Offset = "0x42B250", Length = "0x8D")]
	public bool Equals(IPnlDlcCellData other)
	{
		return default(bool);
	}
}
