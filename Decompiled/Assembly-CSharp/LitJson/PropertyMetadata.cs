using System;
using System.Reflection;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003F6")]
internal struct PropertyMetadata
{
	[Token(Token = "0x4001612")]
	[FieldOffset(Offset = "0x0")]
	public MemberInfo Info;

	[Token(Token = "0x4001613")]
	[FieldOffset(Offset = "0x8")]
	public bool IsField;

	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0x10")]
	public Type Type;
}
