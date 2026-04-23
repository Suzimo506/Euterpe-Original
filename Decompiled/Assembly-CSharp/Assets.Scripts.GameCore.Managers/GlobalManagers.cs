using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000741")]
public static class GlobalManagers
{
	[Token(Token = "0x400263F")]
	private static AbstractFeverManager s_FeverManager;

	[Token(Token = "0x4002640")]
	private static AbstractGirlManager s_GirlManager;

	[Token(Token = "0x17000657")]
	public static AbstractFeverManager feverManager
	{
		[Address(RVA = "0x792E00", Offset = "0x791600", Length = "0x56")]
		[Token(Token = "0x6004387")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000658")]
	public static AbstractGirlManager girlManager
	{
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x792E60", Offset = "0x791660", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004384")]
	[Address(RVA = "0x792460", Offset = "0x790C60", Length = "0x816")]
	public static void AwakeInit()
	{
	}

	[Token(Token = "0x6004385")]
	[Address(RVA = "0x792D60", Offset = "0x791560", Length = "0x97")]
	public static void StartInit()
	{
	}

	[Address(RVA = "0x792C80", Offset = "0x791480", Length = "0xD9")]
	[Token(Token = "0x6004386")]
	public static void Release()
	{
	}
}
