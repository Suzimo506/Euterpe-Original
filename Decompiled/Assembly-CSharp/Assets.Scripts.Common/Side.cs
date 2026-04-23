using Cpp2ILInjected;
using ProtoBuf;

namespace Assets.Scripts.Common;

[ProtoContract]
[Token(Token = "0x2000986")]
public enum Side
{
	[Token(Token = "0x4003417")]
	Bottom = 1,
	[Token(Token = "0x4003418")]
	Top
}
