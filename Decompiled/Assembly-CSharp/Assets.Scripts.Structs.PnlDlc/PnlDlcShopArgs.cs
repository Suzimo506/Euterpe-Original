using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs.PnlDlc;

[Serializable]
[Token(Token = "0x2000593")]
public struct PnlDlcShopArgs
{
	[Token(Token = "0x40020C8")]
	[FieldOffset(Offset = "0x0")]
	public float mainScale;
}
