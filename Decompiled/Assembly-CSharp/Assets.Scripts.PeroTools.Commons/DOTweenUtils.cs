using System;
using Cpp2ILInjected;
using DG.Tweening;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000694")]
public static class DOTweenUtils
{
	[Token(Token = "0x6003DCB")]
	[Address(RVA = "0x924480", Offset = "0x922C80", Length = "0x164")]
	public static void Kill()
	{
	}

	[Address(RVA = "0x9245F0", Offset = "0x922DF0", Length = "0x155")]
	[Token(Token = "0x6003DCC")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6003DCD")]
	[Address(RVA = "0x924750", Offset = "0x922F50", Length = "0x155")]
	public static void Resume()
	{
	}

	[Token(Token = "0x6003DCE")]
	[Address(RVA = "0x924290", Offset = "0x922A90", Length = "0x1EF")]
	public static Sequence Delay(Action callFunc, float dt)
	{
		return null;
	}

	[Token(Token = "0x6003DCF")]
	[Address(RVA = "0x9248B0", Offset = "0x9230B0", Length = "0x126")]
	public static Sequence Update(Action completeFunc, Func<bool> stopFunc)
	{
		return null;
	}
}
