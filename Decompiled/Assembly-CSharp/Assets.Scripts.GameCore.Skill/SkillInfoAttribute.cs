using System;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x2000720")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x97C0", Offset = "0x8BC0")]
internal class SkillInfoAttribute : Attribute
{
	[Token(Token = "0x4002588")]
	[FieldOffset(Offset = "0x10")]
	private int m_Index;

	[Token(Token = "0x4002589")]
	[FieldOffset(Offset = "0x14")]
	private int m_Type;

	[Token(Token = "0x1700062E")]
	public int index
	{
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		[Token(Token = "0x6004227")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700062F")]
	public int type
	{
		[Token(Token = "0x6004228")]
		[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x7CF350", Offset = "0x7CDB50", Length = "0x34")]
	[Token(Token = "0x6004229")]
	internal SkillInfoAttribute(int type, int index)
	{
	}
}
