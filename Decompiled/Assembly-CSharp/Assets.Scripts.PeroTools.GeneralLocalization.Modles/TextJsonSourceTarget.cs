using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Actions;
using Assets.Scripts.PeroTools.Nice.Events;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Serializable]
[Token(Token = "0x2000682")]
public class TextJsonSourceTarget
{
	[Token(Token = "0x40023C9")]
	[FieldOffset(Offset = "0x10")]
	public Event @event;

	[Token(Token = "0x40023CA")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x37520", Offset = "0x36920")]
	[FieldOffset(Offset = "0x18")]
	public int index;

	[Address(RVA = "0x7632A0", Offset = "0x761AA0", Length = "0x12")]
	[Token(Token = "0x6003D92")]
	public SetText GetSetText(out int indexInPlayables)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref indexInPlayables) = null;
		return null;
	}

	[Address(RVA = "0x7632C0", Offset = "0x761AC0", Length = "0x12F")]
	[Token(Token = "0x6003D93")]
	public static SetText GetSetText(Event @event, int index, out int indexInPlayables)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref indexInPlayables) = null;
		return null;
	}

	[Token(Token = "0x6003D94")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public TextJsonSourceTarget()
	{
	}
}
