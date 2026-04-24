using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000795")]
internal class DBConfigBOSS : BaseDBConfigObject
{
	[Token(Token = "0x400281E")]
	[FieldOffset(Offset = "0x38")]
	private List<BOSSInfo> m_Items;

	[Token(Token = "0x170006BE")]
	protected List<BOSSInfo> list
	{
		[Token(Token = "0x60046C7")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60046C8")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x60046C9")]
	[Address(RVA = "0x6F5AB0", Offset = "0x6F42B0", Length = "0x7A")]
	public DBConfigBOSS()
	{
	}

	[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
	[Token(Token = "0x60046CA")]
	public List<BOSSInfo> GetAllBossConfigs()
	{
		return null;
	}

	[Token(Token = "0x60046CB")]
	[Address(RVA = "0x6F5930", Offset = "0x6F4130", Length = "0x172")]
	public BOSSInfo GetInfoBySceneName(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x60046CC")]
	[Address(RVA = "0x6F5820", Offset = "0x6F4020", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}
