using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Account;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.PeroTools.Platforms;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Datas;

[Token(Token = "0x2000603")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
public class DataManager : Singleton<DataManager>
{
	[Token(Token = "0x40021CC")]
	private const int m_Version = 8;

	[Token(Token = "0x40021CE")]
	[FieldOffset(Offset = "0x18")]
	private ISync m_PlatformISync;

	[Token(Token = "0x40021CF")]
	private const char splitChar = '/';

	[Token(Token = "0x17000573")]
	public Dictionary<string, IData> datas
	{
		[CompilerGenerated]
		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003A89")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000574")]
	public SingletonDataObject Item
	{
		[Token(Token = "0x6003A8C")]
		[Address(RVA = "0x9784C0", Offset = "0x976CC0", Length = "0x13F")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x978600", Offset = "0x976E00", Length = "0xCE")]
		set
		{
		}
	}

	[Token(Token = "0x6003A8D")]
	[Address(RVA = "0x977FC0", Offset = "0x9767C0", Length = "0x17F")]
	private void VersionCheckUp()
	{
	}

	[Token(Token = "0x6003A8E")]
	[Address(RVA = "0x976CC0", Offset = "0x9754C0", Length = "0x343")]
	public void Init()
	{
	}

	[Address(RVA = "0x976570", Offset = "0x974D70", Length = "0x3C1")]
	[Token(Token = "0x6003A8F")]
	private void FixSave()
	{
	}

	[Address(RVA = "0x977950", Offset = "0x976150", Length = "0x29")]
	[Token(Token = "0x6003A90")]
	protected void Load()
	{
	}

	[Token(Token = "0x6003A91")]
	[Address(RVA = "0x977670", Offset = "0x975E70", Length = "0x2D7")]
	private void LoadInit()
	{
	}

	[Address(RVA = "0x977010", Offset = "0x975810", Length = "0x249")]
	[Token(Token = "0x6003A92")]
	protected virtual void LoadData()
	{
	}

	[Token(Token = "0x6003A93")]
	[Address(RVA = "0x977A50", Offset = "0x976250", Length = "0x7")]
	public void Save()
	{
	}

	[Token(Token = "0x6003A94")]
	[Address(RVA = "0x978140", Offset = "0x976940", Length = "0x334")]
	private void _Save()
	{
	}

	[Address(RVA = "0x977980", Offset = "0x976180", Length = "0xC4")]
	[Token(Token = "0x6003A95")]
	public new void Reset()
	{
	}

	[Address(RVA = "0x977DC0", Offset = "0x9765C0", Length = "0x1F6")]
	[Token(Token = "0x6003A96")]
	public string ToJson()
	{
		return null;
	}

	[Address(RVA = "0x977BB0", Offset = "0x9763B0", Length = "0x205")]
	[Token(Token = "0x6003A97")]
	[Obsolete]
	public byte[] ToBytes()
	{
		return null;
	}

	[Token(Token = "0x6003A98")]
	[Address(RVA = "0x977480", Offset = "0x975C80", Length = "0x1E6")]
	public void LoadFromJson(string json)
	{
	}

	[Address(RVA = "0x977260", Offset = "0x975A60", Length = "0x21A")]
	[Token(Token = "0x6003A99")]
	[Obsolete]
	public void LoadFromBytes(byte[] bytes)
	{
	}

	[Address(RVA = "0x976BE0", Offset = "0x9753E0", Length = "0xD6")]
	[Token(Token = "0x6003A9A")]
	public IVariable GetVariable(string uid)
	{
		return null;
	}

	[Address(RVA = "0x977A60", Offset = "0x976260", Length = "0x140")]
	[Token(Token = "0x6003A9B")]
	public void SetVariable(string uid, IVariable variable)
	{
	}

	[Token(Token = "0x6003A9C")]
	[Address(RVA = "0x9769A0", Offset = "0x9751A0", Length = "0x237")]
	public List<string> GetUids()
	{
		return null;
	}

	[Token(Token = "0x6003A9D")]
	[Address(RVA = "0x976940", Offset = "0x975140", Length = "0x5C")]
	public AccountPlatform GetLoginPlatform()
	{
		return default(AccountPlatform);
	}

	[Token(Token = "0x6003A9E")]
	[Address(RVA = "0x978480", Offset = "0x976C80", Length = "0x38")]
	public DataManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
