using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ProtoBuf;

namespace Assets.Scripts.Common;

[ProtoContract]
[Token(Token = "0x2000988")]
internal class UploadHighScore
{
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20430", Offset = "0x1F830")]
	[Token(Token = "0x1700091D")]
	public string bms_version
	{
		[Token(Token = "0x60056AF")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60056B0")]
		[CompilerGenerated]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20510", Offset = "0x1F910")]
	[Token(Token = "0x1700091E")]
	public string music_uid
	{
		[CompilerGenerated]
		[Token(Token = "0x60056B1")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60056B2")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x1700091F")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20710", Offset = "0x1FB10")]
	public int music_difficulty
	{
		[CompilerGenerated]
		[Token(Token = "0x60056B3")]
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
		[Token(Token = "0x60056B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20810", Offset = "0x1FC10")]
	[Token(Token = "0x17000920")]
	public string character_uid
	{
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		[Token(Token = "0x60056B5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		[CompilerGenerated]
		[Token(Token = "0x60056B6")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20970", Offset = "0x1FD70")]
	[Token(Token = "0x17000921")]
	public string elfin_uid
	{
		[CompilerGenerated]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[Token(Token = "0x60056B7")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60056B8")]
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x209C0", Offset = "0x1FDC0")]
	[Token(Token = "0x17000922")]
	public int maximum_combo
	{
		[CompilerGenerated]
		[Token(Token = "0x60056B9")]
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x597050", Offset = "0x595850", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60056BA")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20BF0", Offset = "0x1FFF0")]
	[Token(Token = "0x17000923")]
	public int hp
	{
		[CompilerGenerated]
		[Token(Token = "0x60056BB")]
		[Address(RVA = "0x45A8F0", Offset = "0x4590F0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60056BC")]
		[Address(RVA = "0x45AB50", Offset = "0x459350", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000924")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20D50", Offset = "0x20150")]
	public int score
	{
		[Address(RVA = "0x597030", Offset = "0x595830", Length = "0x4")]
		[Token(Token = "0x60056BD")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x597070", Offset = "0x595870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60056BE")]
		set
		{
		}
	}

	[Token(Token = "0x17000925")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20E60", Offset = "0x20260")]
	public float acc
	{
		[Token(Token = "0x60056BF")]
		[CompilerGenerated]
		[Address(RVA = "0x7044A0", Offset = "0x702CA0", Length = "0x6")]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		[Token(Token = "0x60056C0")]
		[Address(RVA = "0x7044B0", Offset = "0x702CB0", Length = "0x6")]
		set
		{
		}
	}

	[Token(Token = "0x17000926")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x20F30", Offset = "0x20330")]
	public int miss
	{
		[CompilerGenerated]
		[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
		[Token(Token = "0x60056C1")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60056C2")]
		[Address(RVA = "0x7044C0", Offset = "0x702CC0", Length = "0x4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000927")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x21120", Offset = "0x20520")]
	public string judge
	{
		[CompilerGenerated]
		[Token(Token = "0x60056C3")]
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x51B9F0", Offset = "0x51A1F0", Length = "0xC")]
		[Token(Token = "0x60056C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000928")]
	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x21210", Offset = "0x20610")]
	public List<Beat> beats
	{
		[CompilerGenerated]
		[Token(Token = "0x60056C5")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60056C6")]
		[CompilerGenerated]
		[Address(RVA = "0x51B9E0", Offset = "0x51A1E0", Length = "0xC")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x270B0", Offset = "0x264B0")]
	[Token(Token = "0x17000929")]
	public string steam_id
	{
		[CompilerGenerated]
		[Token(Token = "0x60056C7")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60056C8")]
		[Address(RVA = "0x5A6760", Offset = "0x5A4F60", Length = "0xC")]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x27200", Offset = "0x26600")]
	[Token(Token = "0x1700092A")]
	public string devices_id
	{
		[CompilerGenerated]
		[Token(Token = "0x60056C9")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x5C14A0", Offset = "0x5BFCA0", Length = "0xC")]
		[Token(Token = "0x60056CA")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Attribute(Name = "ProtoMemberAttribute", RVA = "0x27450", Offset = "0x26850")]
	[Token(Token = "0x1700092B")]
	public int music_map_start_delay
	{
		[Address(RVA = "0x4D0B40", Offset = "0x4CF340", Length = "0x4")]
		[Token(Token = "0x60056CB")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60056CC")]
		[Address(RVA = "0x7044D0", Offset = "0x702CD0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x60056CD")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public UploadHighScore()
	{
	}
}
