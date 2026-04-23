using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ProtoBuf;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000987")]
[ProtoContract]
public class Beat
{
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20430", Offset = "0x1F830")]
	[Token(Token = "0x17000911")]
	public string note_type
	{
		[Token(Token = "0x6005696")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6005697")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x17000912")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20510", Offset = "0x1F910")]
	public int offset
	{
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		[Token(Token = "0x6005698")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6005699")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20710", Offset = "0x1FB10")]
	[Token(Token = "0x17000913")]
	public int score
	{
		[Token(Token = "0x600569A")]
		[CompilerGenerated]
		[Address(RVA = "0x597040", Offset = "0x595840", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x597080", Offset = "0x595880", Length = "0x4")]
		[Token(Token = "0x600569B")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000914")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20810", Offset = "0x1FC10")]
	public Side side
	{
		[Token(Token = "0x600569C")]
		[CompilerGenerated]
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		get
		{
			return default(Side);
		}
		[CompilerGenerated]
		[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
		[Token(Token = "0x600569D")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20970", Offset = "0x1FD70")]
	[Token(Token = "0x17000915")]
	public int fever_start
	{
		[CompilerGenerated]
		[Address(RVA = "0x42D1F0", Offset = "0x42B9F0", Length = "0x4")]
		[Token(Token = "0x600569E")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x42D210", Offset = "0x42BA10", Length = "0x4")]
		[Token(Token = "0x600569F")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x209C0", Offset = "0x1FDC0")]
	[Token(Token = "0x17000916")]
	public int fever_end
	{
		[Token(Token = "0x60056A0")]
		[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60056A1")]
		[Address(RVA = "0x4879F0", Offset = "0x4861F0", Length = "0x4")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20BF0", Offset = "0x1FFF0")]
	[Token(Token = "0x17000917")]
	public int fever_value
	{
		[Address(RVA = "0x597010", Offset = "0x595810", Length = "0x4")]
		[Token(Token = "0x60056A2")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x487A90", Offset = "0x486290", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60056A3")]
		set
		{
		}
	}

	[Token(Token = "0x17000918")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20D50", Offset = "0x20150")]
	public int note_id
	{
		[Token(Token = "0x60056A4")]
		[CompilerGenerated]
		[Address(RVA = "0x597020", Offset = "0x595820", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x487A80", Offset = "0x486280", Length = "0x4")]
		[Token(Token = "0x60056A5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000919")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20E60", Offset = "0x20260")]
	public int config_id
	{
		[Token(Token = "0x60056A6")]
		[CompilerGenerated]
		[Address(RVA = "0x597000", Offset = "0x595800", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Address(RVA = "0x597060", Offset = "0x595860", Length = "0x4")]
		[Token(Token = "0x60056A7")]
		set
		{
		}
	}

	[Token(Token = "0x1700091A")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20F30", Offset = "0x20330")]
	public int combo
	{
		[CompilerGenerated]
		[Token(Token = "0x60056A8")]
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60056A9")]
		[Address(RVA = "0x597050", Offset = "0x595850", Length = "0x4")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x21120", Offset = "0x20520")]
	[Token(Token = "0x1700091B")]
	public int add_time
	{
		[Address(RVA = "0x45A8F0", Offset = "0x4590F0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60056AA")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60056AB")]
		[Address(RVA = "0x45AB50", Offset = "0x459350", Length = "0x4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700091C")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x21210", Offset = "0x20610")]
	public int note_judge
	{
		[CompilerGenerated]
		[Token(Token = "0x60056AC")]
		[Address(RVA = "0x597030", Offset = "0x595830", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Address(RVA = "0x597070", Offset = "0x595870", Length = "0x4")]
		[Token(Token = "0x60056AD")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60056AE")]
	public Beat()
	{
	}
}
