using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Database.DataClass;

[Token(Token = "0x200081B")]
public class AlbumTagInfo
{
	[Token(Token = "0x4002A51")]
	[FieldOffset(Offset = "0x10")]
	private int m_TagIndex;

	[Token(Token = "0x4002A52")]
	[FieldOffset(Offset = "0x18")]
	public string tagUid;

	[Token(Token = "0x4002A53")]
	[FieldOffset(Offset = "0x20")]
	public string name;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002A54")]
	private List<string> m_MusicUids;

	[Token(Token = "0x4002A55")]
	[FieldOffset(Offset = "0x30")]
	private List<AlbumDisplayMusic> m_DisplayMusicUids;

	[Token(Token = "0x4002A56")]
	[FieldOffset(Offset = "0x38")]
	private List<DBConfigAlbums.AlbumsInfo> m_AlbumsInfos;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002A57")]
	public bool isWeekFree;

	[Token(Token = "0x4002A58")]
	[FieldOffset(Offset = "0x41")]
	public bool isNew;

	[Token(Token = "0x4002A59")]
	[FieldOffset(Offset = "0x42")]
	public bool isDisplayTitle;

	[Token(Token = "0x4002A5A")]
	[FieldOffset(Offset = "0x48")]
	public DBConfigCustomTags.CustomTagInfo customInfo;

	[Token(Token = "0x4002A5B")]
	[FieldOffset(Offset = "0x50")]
	public string iconName;

	[Token(Token = "0x4002A5C")]
	[FieldOffset(Offset = "0x58")]
	public Texture2D icon;

	[Token(Token = "0x4002A5D")]
	[FieldOffset(Offset = "0x60")]
	public bool isReverseUidList;

	[Token(Token = "0x17000832")]
	public List<string> musicUids
	{
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000833")]
	public bool isCustomTag
	{
		[Address(RVA = "0x10254B0", Offset = "0x1023CB0", Length = "0xB")]
		[Token(Token = "0x6004AD1")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000834")]
	public int tagIndex
	{
		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000835")]
	public List<DBConfigAlbums.AlbumsInfo> albumsInfos
	{
		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000836")]
	public string tagName
	{
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x10254C0", Offset = "0x1023CC0", Length = "0x16D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004ACF")]
	[Address(RVA = "0x1024B80", Offset = "0x1023380", Length = "0x79")]
	public void GetDisplayAlbums(List<AlbumDisplayMusic> buffer, bool clear = false)
	{
	}

	[Token(Token = "0x6004AD6")]
	[Address(RVA = "0x1024470", Offset = "0x1022C70", Length = "0x5E9")]
	public void AddTagUids(List<string> buffer)
	{
	}

	[Token(Token = "0x6004AD7")]
	[Address(RVA = "0x1024A60", Offset = "0x1023260", Length = "0x6D")]
	public void ClearTagUids()
	{
	}

	[Token(Token = "0x6004AD8")]
	[Address(RVA = "0x1024FD0", Offset = "0x10237D0", Length = "0x87")]
	public void SetTagUids(List<string> uids)
	{
	}

	[Token(Token = "0x6004AD9")]
	[Address(RVA = "0x1025060", Offset = "0x1023860", Length = "0x12E")]
	public void SetWeekFree(int albumJsonIndex)
	{
	}

	[Token(Token = "0x6004ADA")]
	[Address(RVA = "0x1025190", Offset = "0x1023990", Length = "0x12A")]
	public void SetWeekFree(string[] freeWeekMusicUids)
	{
	}

	[Token(Token = "0x6004ADB")]
	[Address(RVA = "0x1024E60", Offset = "0x1023660", Length = "0x167")]
	public void LinkMusicUidList()
	{
	}

	[Token(Token = "0x6004ADC")]
	[Address(RVA = "0x1024DD0", Offset = "0x10235D0", Length = "0x87")]
	public void InitCustomTagInfo(DBConfigCustomTags.CustomTagInfo info)
	{
	}

	[Token(Token = "0x6004ADD")]
	[Address(RVA = "0x1024D50", Offset = "0x1023550", Length = "0x79")]
	public void GetMusicUids(List<string> buffer, bool clear = false)
	{
	}

	[Address(RVA = "0x10252C0", Offset = "0x1023AC0", Length = "0x110")]
	[Token(Token = "0x6004ADE")]
	public void ShallowCopy(AlbumTagInfo tagInfo)
	{
	}

	[Address(RVA = "0x1024C00", Offset = "0x1023400", Length = "0x143")]
	[Token(Token = "0x6004ADF")]
	public void GetIconAsync(Action<Texture2D> callback)
	{
	}

	[Token(Token = "0x6004AE0")]
	[Address(RVA = "0x1024AD0", Offset = "0x10232D0", Length = "0xAB")]
	public string GetChineseTagInfoName()
	{
		return null;
	}

	[Token(Token = "0x6004AE1")]
	[Address(RVA = "0x10253E0", Offset = "0x1023BE0", Length = "0xC3")]
	public AlbumTagInfo()
	{
	}
}
