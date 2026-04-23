using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace PeroTools.Others;

[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x7CD0", Offset = "0x70D0")]
[Token(Token = "0x2000443")]
public sealed class AnimationSelector : Attribute
{
	[Token(Token = "0x1700047F")]
	public string animatorFieldName
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x600325B")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600325C")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600325D")]
	[Address(RVA = "0x4EE550", Offset = "0x4ECD50", Length = "0x27")]
	public AnimationSelector()
	{
	}

	[Address(RVA = "0x4EE580", Offset = "0x4ECD80", Length = "0x30")]
	[Token(Token = "0x600325E")]
	public AnimationSelector(string animFieldName)
	{
	}

	[Address(RVA = "0x4EE450", Offset = "0x4ECC50", Length = "0xFE")]
	[Token(Token = "0x600325F")]
	private static GUIContent[] StringsToGUIContents(string[] strs)
	{
		return null;
	}
}
