using System;
using Cpp2ILInjected;

[Token(Token = "0x2000016")]
public struct SacPlaySetting
{
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x0")]
	public int objIdx;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000073")]
	public string stateActionName;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000074")]
	public string skeletonActionName;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x18")]
	public bool useAnimator;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x20")]
	public Action customCompleteEvt;
}
