using System;
using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectControl.MutiGirlController;

[Token(Token = "0x200048C")]
[Flags]
public enum MultiCharaType
{
	[Token(Token = "0x4001892")]
	Main = 1,
	[Token(Token = "0x4001893")]
	Support = 2
}
