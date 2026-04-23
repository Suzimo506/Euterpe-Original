using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000670")]
public class PositionOption : OptionGeneric<PositionSource, PositionOption.Property>
{
	[Serializable]
	[Token(Token = "0x2000C12")]
	public class Property
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003C25")]
		public Vector3 position;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6006047")]
		public Property()
		{
		}
	}

	[Token(Token = "0x6003D6C")]
	[Address(RVA = "0x761670", Offset = "0x75FE70", Length = "0x44")]
	protected override void OnApply(PositionSource source, Localization localization)
	{
	}

	[Address(RVA = "0x7615E0", Offset = "0x75FDE0", Length = "0x8C")]
	[Token(Token = "0x6003D6D")]
	protected override Property DefaultValue(Localization localization)
	{
		return null;
	}

	[Address(RVA = "0x7616C0", Offset = "0x75FEC0", Length = "0x38")]
	[Token(Token = "0x6003D6E")]
	public PositionOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
