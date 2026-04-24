using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B0")]
public class DBConfigCollectionBundle : BaseDBConfigLocalObject<DBConfigLocalCollectionBundle, LocalCollectionBundle>
{
	[Token(Token = "0x40028A2")]
	[FieldOffset(Offset = "0x40")]
	private List<CollectionBundle> m_Items;

	[Token(Token = "0x170006CD")]
	protected List<CollectionBundle> list
	{
		[Token(Token = "0x6004725")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004726")]
		[Address(RVA = "0x6F4390", Offset = "0x6F2B90", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x6004727")]
	[Address(RVA = "0x6F7F90", Offset = "0x6F6790", Length = "0x9C")]
	public DBConfigCollectionBundle()
	{
		((BaseDBConfigLocalObject<, >)(object)this)._002Ector();
	}

	[Token(Token = "0x6004728")]
	[Address(RVA = "0x6F7480", Offset = "0x6F5C80", Length = "0xF7")]
	public void GetAllCollectionBundleData(List<CollectionBundle> datas)
	{
	}

	[Token(Token = "0x6004729")]
	[Address(RVA = "0x6F7710", Offset = "0x6F5F10", Length = "0x5A")]
	public CollectionBundle GetCollectionBundleByIndex(int index)
	{
		return null;
	}

	[Address(RVA = "0x6F7770", Offset = "0x6F5F70", Length = "0x172")]
	[Token(Token = "0x600472A")]
	public CollectionBundle GetCollectionBundleByUid(string uid)
	{
		return null;
	}

	[Token(Token = "0x600472B")]
	[Address(RVA = "0x6F78F0", Offset = "0x6F60F0", Length = "0x2A3")]
	public bool GetCollectionBundlePriceGradientByCollectionBundleUid(string collectionBundleUid, out CollectionBundlePriceGradient out_cbpg)
	{
		System.Runtime.CompilerServices.Unsafe.As<CollectionBundlePriceGradient, @null>(ref out_cbpg) = null;
		return default(bool);
	}

	[Token(Token = "0x600472C")]
	[Address(RVA = "0x6F7C70", Offset = "0x6F6470", Length = "0xDB")]
	public string[] GetMusicPackageInCollectionBundleUid(string collectionBundleUid)
	{
		return null;
	}

	[Token(Token = "0x600472D")]
	[Address(RVA = "0x6F7DF0", Offset = "0x6F65F0", Length = "0x190")]
	public bool IsAlbumBelongToCollectionBundle(string albumUid)
	{
		return default(bool);
	}

	[Token(Token = "0x600472E")]
	[Address(RVA = "0x6F7580", Offset = "0x6F5D80", Length = "0x185")]
	public CollectionBundle GetCollectionBundleByAlbumUid(string albumUid)
	{
		return null;
	}

	[Token(Token = "0x600472F")]
	[Address(RVA = "0x6F7D50", Offset = "0x6F6550", Length = "0x97")]
	public bool GetPackagesInCollectionBundleByUid(string uid, List<string> buffer)
	{
		return default(bool);
	}

	[Address(RVA = "0x6F7BA0", Offset = "0x6F63A0", Length = "0xC7")]
	[Token(Token = "0x6004730")]
	public int GetIndexByUid(string uid)
	{
		return default(int);
	}

	[Address(RVA = "0x6F7370", Offset = "0x6F5B70", Length = "0x100")]
	[Token(Token = "0x6004731")]
	public override void Deserialize(string str)
	{
	}
}
