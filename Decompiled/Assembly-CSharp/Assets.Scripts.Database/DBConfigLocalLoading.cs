using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007DB")]
public class DBConfigLocalLoading : BaseDBConfigObject
{
	[Token(Token = "0x4002956")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalLoadingInfo> m_Items;

	[Token(Token = "0x17000716")]
	protected List<LocalLoadingInfo> list
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x60047EA")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x60047EB")]
		private set
		{
		}
	}

	[Address(RVA = "0x6FD3D0", Offset = "0x6FBBD0", Length = "0x7A")]
	[Token(Token = "0x60047EC")]
	public DBConfigLocalLoading()
	{
	}

	[Address(RVA = "0x6FD250", Offset = "0x6FBA50", Length = "0x100")]
	[Token(Token = "0x60047ED")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x6FD360", Offset = "0x6FBB60", Length = "0x6B")]
	[Token(Token = "0x60047EE")]
	public LocalLoadingInfo GetInfoByIndex(int index)
	{
		return null;
	}
}
