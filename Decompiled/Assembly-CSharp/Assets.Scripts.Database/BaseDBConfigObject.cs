using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000785")]
public abstract class BaseDBConfigObject : ISerialize
{
	[Token(Token = "0x40027BF")]
	[FieldOffset(Offset = "0x10")]
	protected string m_Text;

	[Token(Token = "0x40027C0")]
	[FieldOffset(Offset = "0x18")]
	protected string m_FileName;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40027C1")]
	protected Type m_InfoType;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40027C2")]
	protected Type m_LocalType;

	[Token(Token = "0x170006A7")]
	public string text
	{
		[Token(Token = "0x600466F")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A8")]
	public string fileName
	{
		[Token(Token = "0x6004670")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A9")]
	protected IList listInterface
	{
		[CompilerGenerated]
		[Token(Token = "0x6004671")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004672")]
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x170006AA")]
	public virtual int count
	{
		[Token(Token = "0x6004673")]
		[Address(RVA = "0x6EFBB0", Offset = "0x6EE3B0", Length = "0x48")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004674")]
	[Address(RVA = "0x6EF900", Offset = "0x6EE100", Length = "0x162")]
	public object GetValue(int index, string cmpKey)
	{
		return null;
	}

	[Address(RVA = "0x6EF690", Offset = "0x6EDE90", Length = "0x262")]
	[Token(Token = "0x6004675")]
	public object GetValue(string cmpKey, string cmpValue, string targetKey)
	{
		return null;
	}

	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	[Token(Token = "0x6004676")]
	public virtual string Serialize()
	{
		return null;
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6004677")]
	public abstract void Deserialize(string str);

	[Address(RVA = "0x6EF640", Offset = "0x6EDE40", Length = "0x49")]
	[Token(Token = "0x6004678")]
	public virtual bool DeserializeLocal(string fileName, string str, int language)
	{
		return default(bool);
	}

	[Address(RVA = "0x6EFA70", Offset = "0x6EE270", Length = "0x135")]
	[Token(Token = "0x6004679")]
	public bool LoadConfigFile(string fileName, bool cache, string text)
	{
		return default(bool);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600467A")]
	protected BaseDBConfigObject()
	{
	}
}
