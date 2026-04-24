using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Serializable]
[Token(Token = "0x20008E5")]
public struct WelcomeUIForm
{
	[Token(Token = "0x4002F3F")]
	[FieldOffset(Offset = "0x0")]
	public Color txtColor;

	[Token(Token = "0x4002F40")]
	[FieldOffset(Offset = "0x10")]
	public bool outlineActive;

	[Token(Token = "0x4002F41")]
	[FieldOffset(Offset = "0x11")]
	public bool txtActive;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002F42")]
	public List<int> welcomeList;
}
