using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000786")]
public abstract class BaseDataObject
{
	[Token(Token = "0x40027C5")]
	[FieldOffset(Offset = "0x18")]
	protected Dictionary<string, object> m_MaskValue;

	[Token(Token = "0x170006AB")]
	public int listIndex
	{
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600467C")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		[Token(Token = "0x600467B")]
		protected set
		{
		}
	}

	[Token(Token = "0x600467D")]
	[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
	public virtual void Init(int index)
	{
	}

	[Token(Token = "0x600467E")]
	[Address(RVA = "0x6EFC00", Offset = "0x6EE400", Length = "0x1F0")]
	public void AddMaskValue(string fieldName, object maskValue)
	{
	}

	[Token(Token = "0x600467F")]
	[Address(RVA = "0x6EFF00", Offset = "0x6EE700", Length = "0x126")]
	public void RemoveMaskValue(string fieldName)
	{
	}

	[Token(Token = "0x6004680")]
	[Address(RVA = "0x6EFE00", Offset = "0x6EE600", Length = "0xFF")]
	public virtual void ClearMaskValue()
	{
	}

	[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
	[Token(Token = "0x6004681")]
	protected BaseDataObject()
	{
	}
}
