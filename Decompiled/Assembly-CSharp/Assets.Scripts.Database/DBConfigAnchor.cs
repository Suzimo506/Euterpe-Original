using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000793")]
internal class DBConfigAnchor : BaseDBConfigObject
{
	[Token(Token = "0x4002818")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, AnchorMusicInfo> m_AnchorMusicInfos;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002819")]
	private Dictionary<string, AnchorElfinList> m_AnchorElfinInfos;

	[Token(Token = "0x400281A")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, AnchorBanBgmInfo> m_BanUiBgmInfos;

	[Token(Token = "0x170006BD")]
	public override int count
	{
		[Address(RVA = "0x6F5790", Offset = "0x6F3F90", Length = "0x8A")]
		[Token(Token = "0x60046C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60046C0")]
	[Address(RVA = "0x6F5680", Offset = "0x6F3E80", Length = "0x101")]
	public DBConfigAnchor()
	{
	}

	[Token(Token = "0x60046C1")]
	[Address(RVA = "0x6F5500", Offset = "0x6F3D00", Length = "0x7E")]
	public bool TryGetBanUiBgmIsBan(string musicName, out AnchorBanBgmInfo info)
	{
		System.Runtime.CompilerServices.Unsafe.As<AnchorBanBgmInfo, @null>(ref info) = null;
		return default(bool);
	}

	[Token(Token = "0x60046C2")]
	[Address(RVA = "0x6F55F0", Offset = "0x6F3DF0", Length = "0x83")]
	public bool TryGetMusicIsBan(string musicUid, out AnchorMusicInfo info)
	{
		System.Runtime.CompilerServices.Unsafe.As<AnchorMusicInfo, @null>(ref info) = null;
		return default(bool);
	}

	[Token(Token = "0x60046C3")]
	[Address(RVA = "0x6F5580", Offset = "0x6F3D80", Length = "0x62")]
	public bool TryGetElfin(string elfinIndex, out AnchorElfinList info)
	{
		System.Runtime.CompilerServices.Unsafe.As<AnchorElfinList, @null>(ref info) = null;
		return default(bool);
	}

	[Token(Token = "0x60046C5")]
	[Address(RVA = "0x6F50F0", Offset = "0x6F38F0", Length = "0x403")]
	public override void Deserialize(string str)
	{
	}
}
