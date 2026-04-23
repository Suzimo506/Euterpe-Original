using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200074A")]
public class ShopModule
{
	[Token(Token = "0x400268C")]
	[FieldOffset(Offset = "0x10")]
	public string module_name;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400268D")]
	public ShopManager.ModuleLayout module_type;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400268E")]
	public List<ModuleGoods> goods;

	[Token(Token = "0x6004445")]
	[Address(RVA = "0x6DF880", Offset = "0x6DE080", Length = "0x13C")]
	public void Init()
	{
	}

	[Token(Token = "0x6004446")]
	[Address(RVA = "0x6DF6E0", Offset = "0x6DDEE0", Length = "0x191")]
	public bool HasShopGoods(string language)
	{
		return default(bool);
	}

	[Token(Token = "0x6004447")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ShopModule()
	{
	}
}
