using System.Collections.Generic;
using Assets.Scripts.Database.DataClass;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200078E")]
public class DBConfigAlbums : BaseDBConfigLocalObject<DBConfigLocalAlbums, string>
{
	[Token(Token = "0x2000D04")]
	public class AlbumsInfo : BaseDataObject
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003E86")]
		public string uid;

		[Token(Token = "0x4003E87")]
		[FieldOffset(Offset = "0x28")]
		public string title;

		[Token(Token = "0x4003E88")]
		[FieldOffset(Offset = "0x30")]
		public string tag;

		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003E89")]
		public bool needPurchase;

		[Token(Token = "0x4003E8A")]
		[FieldOffset(Offset = "0x40")]
		public string price;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003E8B")]
		public string jsonName;

		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003E8C")]
		public string prefabsName;

		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003E8D")]
		public bool free;

		[Token(Token = "0x4003E8E")]
		[FieldOffset(Offset = "0x60")]
		public string[] pay_ids;

		[Token(Token = "0x4003E8F")]
		[FieldOffset(Offset = "0x68")]
		protected AlbumExInfo m_AlbumExInfo;

		[Token(Token = "0x17000AEB")]
		public int albumJsonIndex
		{
			[Token(Token = "0x6006331")]
			[Address(RVA = "0x6EF3E0", Offset = "0x6EDBE0", Length = "0x4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000AEC")]
		public int albumUidIndex
		{
			[Token(Token = "0x6006332")]
			[Address(RVA = "0x6EF3F0", Offset = "0x6EDBF0", Length = "0x4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600632F")]
		[Address(RVA = "0x6EF280", Offset = "0x6EDA80", Length = "0xEC")]
		public override void Init(int index)
		{
		}

		[Token(Token = "0x6006330")]
		[Address(RVA = "0x6EF0F0", Offset = "0x6ED8F0", Length = "0xE9")]
		private void ExInfoInit()
		{
		}

		[Address(RVA = "0x6EF1E0", Offset = "0x6ED9E0", Length = "0x9A")]
		[Token(Token = "0x6006333")]
		public void GetAlbumMusicUids(List<string> buffer, bool clear = false)
		{
		}

		[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
		[Token(Token = "0x6006334")]
		public AlbumsInfo()
		{
		}
	}

	[Token(Token = "0x40027F0")]
	[FieldOffset(Offset = "0x40")]
	private List<AlbumsInfo> m_Items;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40027F1")]
	private int m_MaxAlbumUid;

	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40027F2")]
	private int m_diff1TotalNum;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40027F3")]
	private int m_diff2TotalNum;

	[Token(Token = "0x40027F4")]
	[FieldOffset(Offset = "0x54")]
	private int m_diff3TotalNum;

	[Token(Token = "0x40027F5")]
	[FieldOffset(Offset = "0x58")]
	private int m_BarrageMusicTotalNum;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40027F6")]
	private int m_HideMusicTotalNum;

	[Token(Token = "0x40027F7")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_HideMusicUids;

	[Token(Token = "0x170006B7")]
	public int maxAlbunUid
	{
		[Token(Token = "0x60046AB")]
		[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B8")]
	public int diff1TotalNum
	{
		[Address(RVA = "0x6F50D0", Offset = "0x6F38D0", Length = "0x4")]
		[Token(Token = "0x60046AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B9")]
	public int diff2TotalNum
	{
		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x492770", Offset = "0x490F70", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BA")]
	public int diff3TotalNum
	{
		[Token(Token = "0x60046AE")]
		[Address(RVA = "0x6F50E0", Offset = "0x6F38E0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BB")]
	public int hideMusicTotalNum
	{
		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x4E8C70", Offset = "0x4E7470", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BC")]
	protected List<AlbumsInfo> list
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x60046B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x60046AF")]
	[Address(RVA = "0x6F4C50", Offset = "0x6F3450", Length = "0x6D")]
	public bool IsMusicIdBelongsToHideMusicUid(string uid)
	{
		return default(bool);
	}

	[Address(RVA = "0x6F5000", Offset = "0x6F3800", Length = "0xC9")]
	[Token(Token = "0x60046B3")]
	public DBConfigAlbums()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Address(RVA = "0x6F47B0", Offset = "0x6F2FB0", Length = "0x32")]
	[Token(Token = "0x60046B4")]
	public AlbumsInfo GetAlbumInfoByMusicInfo(MusicInfo musicInfo)
	{
		return null;
	}

	[Token(Token = "0x60046B5")]
	[Address(RVA = "0x6F45E0", Offset = "0x6F2DE0", Length = "0x164")]
	public AlbumsInfo GetAlbumInfoByAlbumJsonIndex(int albumIndex)
	{
		return null;
	}

	[Address(RVA = "0x6F4750", Offset = "0x6F2F50", Length = "0x5A")]
	[Token(Token = "0x60046B6")]
	public AlbumsInfo GetAlbumInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60046B7")]
	[Address(RVA = "0x6F48F0", Offset = "0x6F30F0", Length = "0x172")]
	public AlbumTagInfo GetAlbumTagInfo(AlbumsInfo albumsInfo)
	{
		return null;
	}

	[Token(Token = "0x60046B8")]
	[Address(RVA = "0x6F4500", Offset = "0x6F2D00", Length = "0xD3")]
	public int GetAlbumIndexByUid(string uid)
	{
		return default(int);
	}

	[Token(Token = "0x60046B9")]
	[Address(RVA = "0x6F47F0", Offset = "0x6F2FF0", Length = "0xF3")]
	public int GetAlbumJsonIndexByUid(string uid)
	{
		return default(int);
	}

	[Token(Token = "0x60046BA")]
	[Address(RVA = "0x6F4A70", Offset = "0x6F3270", Length = "0x172")]
	public AlbumsInfo GetAlbumsInfoByUid(string uid)
	{
		return null;
	}

	[Token(Token = "0x60046BB")]
	[Address(RVA = "0x6F4BF0", Offset = "0x6F33F0", Length = "0x52")]
	public void GetAllAlbumInfo(List<AlbumsInfo> buffer)
	{
	}

	[Token(Token = "0x60046BC")]
	[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
	public List<AlbumsInfo> GetAllDatas()
	{
		return null;
	}

	[Token(Token = "0x60046BD")]
	[Address(RVA = "0x6F4CC0", Offset = "0x6F34C0", Length = "0x33C")]
	private void StatisticalData()
	{
	}

	[Token(Token = "0x60046BE")]
	[Address(RVA = "0x6F43D0", Offset = "0x6F2BD0", Length = "0x12B")]
	public override void Deserialize(string str)
	{
	}
}
