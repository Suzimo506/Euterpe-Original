using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000675")]
public class ScaleOption : OptionGeneric<ScaleSource, ScaleOption.Property>
{
	[Serializable]
	[Token(Token = "0x2000C13")]
	public class Property
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003C26")]
		public Vector3 scale;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6006048")]
		public Property()
		{
		}
	}

	[Address(RVA = "0x7619C0", Offset = "0x7601C0", Length = "0x44")]
	[Token(Token = "0x6003D77")]
	protected override void OnApply(ScaleSource source, Localization localization)
	{
	}

	[Address(RVA = "0x761930", Offset = "0x760130", Length = "0x8C")]
	[Token(Token = "0x6003D78")]
	protected override Property DefaultValue(Localization localization)
	{
		return null;
	}

	[Token(Token = "0x6003D79")]
	[Address(RVA = "0x761A10", Offset = "0x760210", Length = "0x38")]
	public ScaleOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
