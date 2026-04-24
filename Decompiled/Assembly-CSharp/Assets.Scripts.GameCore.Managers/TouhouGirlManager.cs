using Cpp2ILInjected;
using GameCore.GameObjectLogics.GameObjectManager;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000734")]
public class TouhouGirlManager : GeneralFloatGirlManager
{
	[Token(Token = "0x6004306")]
	[Address(RVA = "0x7DD020", Offset = "0x7DB820", Length = "0xA7")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x7DD1D0", Offset = "0x7DB9D0", Length = "0xA7")]
	[Token(Token = "0x6004307")]
	public override void Release()
	{
	}

	[Address(RVA = "0x7DD0D0", Offset = "0x7DB8D0", Length = "0xFF")]
	[Token(Token = "0x6004308")]
	private void OnTouhouFever()
	{
	}

	[Token(Token = "0x6004309")]
	[Address(RVA = "0x7DD280", Offset = "0x7DBA80", Length = "0x7")]
	public TouhouGirlManager()
	{
	}
}
