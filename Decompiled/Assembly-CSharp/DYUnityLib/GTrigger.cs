using Assets.Scripts.Managers;
using Cpp2ILInjected;

namespace DYUnityLib;

[Token(Token = "0x20004E8")]
internal class GTrigger
{
	[Token(Token = "0x4001A85")]
	private static AbstractEventHandler[] m_EventTriggers;

	[Token(Token = "0x4001A86")]
	private static GEventHandler<decimal> MUSIC_STEP_EVENT;

	[Address(RVA = "0x200BD10", Offset = "0x200A510", Length = "0x2B2")]
	[Token(Token = "0x6003657")]
	public static GEventHandler<T> RegEvent<T>(uint eventIndex)
	{
		return null;
	}

	[Address(RVA = "0x471E80", Offset = "0x470680", Length = "0x8F")]
	[Token(Token = "0x6003658")]
	public static void UnRegEvent(uint eventIndex)
	{
	}

	[Address(RVA = "0x471C10", Offset = "0x470410", Length = "0x126")]
	[Token(Token = "0x6003659")]
	public static void FireEvent(uint eventIndex, decimal tick)
	{
	}

	[Token(Token = "0x600365A")]
	[Address(RVA = "0x471D40", Offset = "0x470540", Length = "0x135")]
	public static void FireEvent(uint eventIndex, uint arg)
	{
	}

	[Address(RVA = "0x471B80", Offset = "0x470380", Length = "0x87")]
	[Token(Token = "0x600365B")]
	public static void ClearEvent()
	{
	}

	[Token(Token = "0x600365C")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public GTrigger()
	{
	}
}
